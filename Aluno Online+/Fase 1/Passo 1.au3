#include <Excel.au3>
#include <String.au3>
#include <Array.au3>
#include <IE.au3>
#include <EditConstants.au3>
#include <GUIConstantsEx.au3>
#include <StaticConstants.au3>
#include <WindowsConstants.au3>
#include <ButtonConstants.au3>

;~ $oErrorHandler = ObjEvent("AutoIt.Error", _ErrFunc)

;~ //Bendito seja o nome de Jesus

Global $grade[20][20]
Global $contdisc, $oIE
$contdisc=0
Global $cod[9]
Global $oExcel = _Excel_Open(False)
Global $oWorkbook = _Excel_BookOpen($oExcel, @ScriptDir & "\GradeVBA.xlsm")
;~ ConsoleWrite( @ScriptDir & "\GradeVBA.xlsm" & @CRLF)
#Region ### START Koda GUI section ### Form=C:\Rename\AutoGrade.kxf
$AutoGrade = GUICreate("AutoGrade", 315, 635, 538, 45)
$Label1 = GUICtrlCreateLabel("Digite os códigos das matérias:", 16, 8, 274, 29)
GUICtrlSetFont(-1, 15, 400, 0, "MS Sans Serif")
$cod[1]=GUICtrlCreateInput("", 104, 120, 121, 21)
$Label2 = GUICtrlCreateLabel("1-", 64, 120, 15, 20)
GUICtrlSetFont(-1, 10, 400, 0, "MS Sans Serif")
$cod[2] = GUICtrlCreateInput("", 105, 174, 121, 21)
$Label3 = GUICtrlCreateLabel("2-", 65, 174, 15, 20)
GUICtrlSetFont(-1, 10, 400, 0, "MS Sans Serif")
$cod[3] = GUICtrlCreateInput("", 105, 230, 121, 21)
$Label4 = GUICtrlCreateLabel("3-", 65, 230, 15, 20)
GUICtrlSetFont(-1, 10, 400, 0, "MS Sans Serif")
$cod[4] = GUICtrlCreateInput("", 105, 286, 121, 21)
$Label5 = GUICtrlCreateLabel("4-", 65, 286, 15, 20)
GUICtrlSetFont(-1, 10, 400, 0, "MS Sans Serif")
$cod[5] = GUICtrlCreateInput("", 105, 342, 121, 21)
$Label6 = GUICtrlCreateLabel("5-", 65, 342, 15, 20)
GUICtrlSetFont(-1, 10, 400, 0, "MS Sans Serif")
$cod[6] = GUICtrlCreateInput("", 105, 398, 121, 21)
$Label7 = GUICtrlCreateLabel("6-", 65, 398, 15, 20)
GUICtrlSetFont(-1, 10, 400, 0, "MS Sans Serif")
$cod[7] = GUICtrlCreateInput("", 105, 454, 121, 21)
$Label8 = GUICtrlCreateLabel("7-", 65, 454, 15, 20)
GUICtrlSetFont(-1, 10, 400, 0, "MS Sans Serif")
$cod[8] = GUICtrlCreateInput("", 105, 510, 121, 21)
$Label9 = GUICtrlCreateLabel("8-", 65, 510, 15, 20)
GUICtrlSetFont(-1, 10, 400, 0, "MS Sans Serif")
$Label10 = GUICtrlCreateLabel("FEN07-02162 ---> 2162", 104, 72, 115, 17)
$Label11 = GUICtrlCreateLabel("IME03-00738 ---> 738", 100, 91, 110, 17)
$Label12 = GUICtrlCreateLabel("Exemplo: Disciplina ---> Código da matéria", 56, 48, 201, 17)
$comecar = GUICtrlCreateButton("Ok", 120, 552, 75, 25)
$Label13 = GUICtrlCreateLabel("Dúvidas? Envie um email para luiscoimbraeng@outlook.com", 8, 592, 295, 17)
GUISetState(@SW_SHOW)
#EndRegion ### END Koda GUI section ###



While 1
	$nMsg = GUIGetMsg()
	Switch $nMsg
		Case $GUI_EVENT_CLOSE
			Exit

		Case $comecar
			Global $oWorkbook = _Excel_BookOpen($oExcel, @ScriptDir & "\GradeVBA.xlsm")
			ok ()
;~

	EndSwitch
WEnd


func ok()
	for $j=1 to 8
		if GUICtrlRead($cod[$j])<>"" Then
;~ 			ConsoleWrite(GUICtrlRead($cod[$j])& @CRLF)
			trabalhar(Int(GUICtrlRead($cod[$j])))
		EndIf
	Next
;~ 	_ArrayDisplay($grade)

	_Excel_RangeWrite($oWorkbook, $oWorkbook.Activesheet, $grade,"S6")
	_Excel_BookSave ( $oWorkbook )
	_IEQuit($oIE)
	MsgBox ( 1, "Completo !!", "Agora abra o arquivo de Excel e edite os horários disponíveis" )
	exit
EndFunc

func trabalhar ($cod)

	$site=('https://www.alunoonline.uerj.br/requisicaoaluno/requisicao.php?requisicao=HorariosTurmasDisciplina&disciplinas[0]='& $cod)
	If $contdisc<>0 then
		_IENavigate($oIE,$site)
	Else
		Global	$oIE=_IECreate ($site,0,0)
	EndIf
	if _IEErrorHandlerRegister() = 1 then
		$body = _IETagNameGetCollection($oIE, "body", 0)
		$text = $body.innerText
		$text=StringReplace($text,@CRLF,"")
		$disc=entre($text,"Disciplina:","TURMA:  1")
		$disc=StringTrimLeft($disc,12)
		$grade[$contdisc][0]=$disc
		$contm=1
		$acaba=false
		do
			$parte=entre($text,"TURMA:  " & $contm,"TURMA:  " & $contm+1)
			if $parte=-1 Then
				$parte=entre($text,"TURMA:  " & $contm,"Observações: Preferencial")
				$acaba=true
			EndIf
			$tempos=entre($parte,"Tempos:  ","Local das Aulas:")
			$tempos=StringTrimRight($tempos,1)
			$atempos=_StringExplode($tempos," ")
			$tempos=""
			for $i=0	To	Ubound($atempos)-1
	;~ 			ConsoleWrite($atempos[$i])
				if StringLen($atempos[$i])>3 Then
					$p1=StringTrimRight($atempos[$i],3)
					$p2=StringTrimLeft($atempos[$i],2)
					$atempos[$i]=$p1& " " & $p2
				EndIf
				$tempos=$tempos & $atempos[$i] & " "
			Next
			$prof=entre($parte,"Docente: ","Vagas Atualizadas")
			$prof=StringTrimRight($prof,1)
			$atempos=StringTrimRight($atempos,1)
			if $prof <> -1 and $tempos <> -1 and $parte <> -1 Then
	;~ 			IniWrite("list.ini", $disc, $contm, $tempos & " ---------- " & $prof)
				$grade[$contdisc][$contm]=$tempos
			EndIf
			$contm=$contm+1
		until $acaba=true
	;~ IniWrite("html.ini", 0,0, $text)
		$contdisc=$contdisc+1
	endif
EndFunc


Func entre($x,$a1,$a2)
Local $info, $xp
$xp = _StringBetween ( $x, $a1, $a2 )
$info = _ArrayToString ($xp)
Return $info

EndFunc
