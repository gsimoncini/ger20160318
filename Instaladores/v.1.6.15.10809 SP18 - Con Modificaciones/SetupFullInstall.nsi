;--------------------------------
;Include Modern UI
!include "MUI.nsh"  

;Seleccionamos el algoritmo de compresi�n utilizado para comprimir nuestra aplicaci�n
SetCompressor LZMA          
;--------------------------------
;Con esta opci�n alertamos al usuario cuando pulsa el bot�n cancelar y le pedimos confirmaci�n para abortar
;la instalaci�n
!define mui_abortwarning "�Est� seguro?"
!define MUI_FINISHPAGE_RUN "$INSTDIR\MZ.Erp.exe"
;Definimos el valor de la variable VERSION
!define VERSION "18.10809" 
;--------------------------------
;Pages

  ;Mostramos la p�gina de bienvenida 
  !insertmacro MUI_PAGE_WELCOME 
  ;P�gina donde mostramos el contrato de licencia 
  !insertmacro MUI_PAGE_LICENSE "Licencia.html"
  ;p�gina donde se muestran las distintas secciones definidas 
  !insertmacro MUI_PAGE_COMPONENTS 
  ;p�gina donde se selecciona el directorio donde instalar nuestra aplicacion 
  !insertmacro MUI_PAGE_DIRECTORY 
  ;p�gina de instalaci�n de ficheros 
  !insertmacro MUI_PAGE_INSTFILES 
  ;p�gina final
  !insertmacro MUI_PAGE_FINISH
  


;p�ginas referentes al desinstalador
!insertmacro MUI_UNPAGE_WELCOME
!insertmacro MUI_UNPAGE_CONFIRM
!insertmacro MUI_UNPAGE_INSTFILES
!insertmacro MUI_UNPAGE_FINISH

;--------------------------------
;Define el lenguaje en espa�ol
!insertmacro MUI_LANGUAGE "Spanish"

;--------------------------------

;Establecer el nombre del archivo de instalaci�n
OutFile "ClassicFull.exe"

;Establecer el nombre de la aplicaci�n
Name "MZ.Erp.Classic"
Caption "MZ.Erp.Classic"

;Comprobacion de integridad del fichero activada
CRCCheck on

;Estilos visuales del XP activados
XPStyle on

Var PATH_ACCESO_DIRECTO

InstallDir $PROGRAMFILES\MZ.Erp

InstallDirRegKey HKLM SOFTWARE\MZ.Erp.Classic InstallDir

DirText "Elija un directorio donde instalar la aplicaci�n:"

AutoCloseWindow false

;ShowInstDetails show

SetOverwrite on

SetDatablockOptimize on

SetCompress auto

UninstallText "Este es el desinstalador del MZ.Erp.Classic."

;--------------------------------

Section "Programa"

StrCpy $PATH_ACCESO_DIRECTO "MZ.Erp"
SetOutPath $INSTDIR


;Incluimos todos los ficheros que componen nuestra aplicaci�n
File /r .\mz.erp.exe.config
File /r .\ext\*.*
File /r .\bin\*.* 
File /r .\Licencia.html

ExecWait '"$INSTDIR\dotnetfx - Framework 2.0.exe" /q'

Delete "$INSTDIR\dotnetfx - Framework 2.0.exe"

;Hacemos que la instalaci�n se realice para todos los usuarios del sistema
SetShellVarContext all
;Creamos los directorios, acesos directos y claves del registro que queramos...
	CreateDirectory "$SMPROGRAMS\$PATH_ACCESO_DIRECTO"
	CreateShortCut "$SMPROGRAMS\$PATH_ACCESO_DIRECTO\MZ.Erp.lnk" \
				   "$INSTDIR\MZ.Erp.exe"
	CreateShortCut "$DESKTOP\MZ.Erp.lnk" \
				   "$INSTDIR\MZ.erp.exe"
	CreateShortCut "$SMPROGRAMS\$PATH_ACCESO_DIRECTO\Licencia.lnk" \
				   "$INSTDIR\Licencia.html"
				   

		RegDLL $INSTDIR\winfis32.dll
		RegDLL $INSTDIR\Ifepson.ocx
		RegDLL $INSTDIR\hasar320.ocx
		RegDLL $INSTDIR\Fiscal051122.ocx
	
;Creamos tambi�n el aceso directo al instalador
        CreateShortCut "$SMPROGRAMS\$PATH_ACCESO_DIRECTO\Desinstalar.lnk" \
                       "$INSTDIR\uninstall.exe"

        WriteRegStr HKLM SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\$PATH_ACCESO_DIRECTO \
            "MZ" "Aplicaci�n para MZ"
        WriteRegStr HKLM SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\$PATH_ACCESO_DIRECTO \
            "MZS" '"$INSTDIR\uninstall.exe"'
        WriteUninstaller "uninstall.exe"

        WriteRegStr HKLM SOFTWARE\$PATH_ACCESO_DIRECTO "InstallDir" $INSTDIR
       
        WriteRegStr HKLM SOFTWARE\$PATH_ACCESO_DIRECTO "Version" "${VERSION}"
        ;Mostramos el
;directorio donde se crearon los acesos directos
	;Exec "$SMPROGRAMS\MZ Inforamtica"
	;Exec "$INSTDIR\Mz.erp.exe"
	
	ExecWait '"$INSTDIR\registrar.bat" /q'

	Delete "$INSTDIR\registrar.bat"
SectionEnd

;--------------------------------

Section "Uninstall"
        StrCpy $PATH_ACCESO_DIRECTO "MZ Informatica"
        SetShellVarContext all
        RMDir /r $SMPROGRAMS\$PATH_ACCESO_DIRECTO
        RMDir /r $INSTDIR
		DeleteRegKey HKLM SOFTWARE\$PATH_ACCESO_DIRECTO
        DeleteRegKey HKLM SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\$PATH_ACCESO_DIRECTO
		
		Delete "$DESKTOP\MZ.Erp.lnk" 
SectionEnd

