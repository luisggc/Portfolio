#include <ButtonConstants.au3>
#include <EditConstants.au3>
#include <GUIConstantsEx.au3>
#include <StaticConstants.au3>
#include <WindowsConstants.au3>
#include <String.au3>
#include <Array.au3>
#include <IE.au3>
#include <MsgBoxConstants.au3>

$pt = 0
$cont = 0
$urlp = "https://www.youtube.com/results?search_query="
$link =""
#Region ### START Koda GUI section ### Form=C:\Users\Luis\Downloads\koda_1.7.3.0\Forms\Form1.kxf
$Form1 = GUICreate("Youtube Link Generator", 623, 449, 513, 309)
$caixanomes = GUICtrlCreateEdit("", 64, 24, 465, 361)
$botao = GUICtrlCreateButton("Links !", 536, 392, 73, 49)
$Label1 = GUICtrlCreateLabel("Powered by LG", 240, 416, 77, 17)
GUISetState(@SW_SHOW)
#EndRegion ### END Koda GUI section ###

While 1
	$nMsg = GUIGetMsg()
	Switch $nMsg

		 Case $GUI_EVENT_CLOSE
			Exit
		 Case $botao
			   $nome = GUICtrlRead($caixanomes)
			   $vetor= _StringExplode($nome,@CRLF)
			   $tamanho = ubound ($vetor)
			   GUISetState(@SW_HIDE)

			   #Region ### START Koda GUI section ### Form=C:\Users\Luis\Downloads\koda_1.7.3.0\Forms\Form2.kxf
			   $Form2 = GUICreate("Youtube Link Generator", 622, 447, 509, 307)
			   $caixalinks = GUICtrlCreateEdit("", 64, 24, 489, 305)
			   GUICtrlSetData(-1, "")
			   $Progress = GUICtrlCreateProgress(128, 360, 326, 16)
			   $progressogeral = GUICtrlCreateProgress(40, 384, 537, 25)
			   $Label1 = GUICtrlCreateLabel("Powered by LG", 240, 424, 77, 17)
			   $feito = GUICtrlCreateLabel("0/" & $tamanho, 280, 336, 21, 17)
			   GUISetState(@SW_SHOW)
			   #EndRegion ### END Koda GUI section ###
			   GUICtrlSetData($Progress,(0))

			   for $k=0 to ($tamanho - 1)

			   achar($vetor)

			   next



					 While 1
						 $nMsg = GUIGetMsg()
						 Switch $nMsg
							 Case $GUI_EVENT_CLOSE
								  GUIDelete()
								  exit
						 EndSwitch
					 WEnd



	EndSwitch

WEnd








func achar($vetor)
   $nome = $vetor[$k]
   $nome = StringReplace ($nome, " ","+")
				  $p = 5
				  $pt = $p/$tamanho + $cont*100/$tamanho
				  GUICtrlSetData($Progress,$p)
				  GUICtrlSetData($progressogeral,$pt)
				  $nome = StringReplace ($nome, "á","%C3%A1")
				  $nome = StringReplace ($nome, "é","%C3%A9")
				  $p = $p+5
				  $pt = $p/$tamanho + $cont*100/$tamanho
				  GUICtrlSetData($Progress,$p)
				  GUICtrlSetData($progressogeral,$pt)
				  $nome = StringReplace ($nome, "í","%C3%AD")
				  $nome = StringReplace ($nome, "ó","%C3%B3")
				  $p = $p+5
				  $pt = $p/$tamanho + $cont*100/$tamanho
				  GUICtrlSetData($Progress,$p)
				  GUICtrlSetData($progressogeral,$pt)
				  $nome = StringReplace ($nome, "ú","%C3%BA")
				  $nome = StringReplace ($nome, "ã","%C3%A3")
				  $nome = StringReplace ($nome, "ã","%C3%B5")
				  $p = $p+5
				  $pt = $p/$tamanho + $cont*100/$tamanho
				  GUICtrlSetData($Progress,$p)
				  GUICtrlSetData($progressogeral,$pt)



					 $oIE = _IECreate ($urlp&$nome,0,0)
					 $text = _IEDocReadHTML($oIE)
					 $substring = 'href="/watch?v='
					 $p = $p+20
					 $pt = $p/$tamanho + $cont*100/$tamanho
					 GUICtrlSetData($Progress,$p)
					 GUICtrlSetData($progressogeral,$pt)
					 $aArray1 = _StringExplode($text, $substring)
					 _ArrayDelete ($aArray1,0)
					 $text =  _ArrayToString ($aArray1)
					 $aArray2 = _StringExplode($text, '"', 1)
					 _ArrayDelete($aArray2,1)
					 $numeros =  _ArrayToString ($aArray2)
					 $link = $link & ('https://www.youtube.com/watch?v=') & $numeros & @CRLF
					 $p = $p+60
					 $pt = $p/$tamanho + $cont*100/$tamanho
					 GUICtrlSetData ( $caixalinks, $link)
					 GUICtrlSetData($Progress,$p)
					 GUICtrlSetData($progressogeral,$pt)

					 $p = 0
					 $cont = $cont + 1
					 $feito = GUICtrlCreateLabel($cont & "/" & $tamanho, 280, 336, 21, 17)


EndFunc













;~  Pesquisa
;~ 		 $pesquisa = _IEGetObjByName( $oIE, "search_query")
;~ 		 $search =  _IEGetObjById( $oIE, "search-btn")
;~ 		 _IEFormElementSetValue ($pesquisa, $nome)
;~ 		 _IEAction ($search, "click")

;~ 		 obter link

;~ 		 $body = _IETagNameGetCollection($oIE, "body", 0)
;~          $text = $body.innerText
;~ 		 $temad = StringInStr($text, "<AD>")
;~ 		 $temlive = StringInStr($text, ">LIVE NOW<")
;~ 		 rep = 0

;~ 		 if $itemlive <>0 then
;~ 			while rep <> $itemlive Then
;~ 			   $aArray1 = _StringExplode($text, ">LIVE NOW<", 0)
;~ 			   _ArrayDelete ($aArray1,0)
;~ 			   rep = rep + 1
;~ 			EndFunc
;~ 			rep = 0
;~ 			$text =  _ArrayToString ($aArray1)
;~ 		 EndIf


;~ 		 if $temad <> 0

;~ 			Do
;~ 			   $aArray2 = _StringExplode($text, "<AD>", 0)
;~ 			   _ArrayDelete ($aArray2,0)
;~ 			   rep = rep+1
;~ 			Until $temad <> rep
;~ 			$text =  _ArrayToString ($aArray2)
;~ 		 EndIf

