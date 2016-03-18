ECHO "Directorio Solution: " %1


MKDIR   lib;
MKDIR   Assemblies;
MKDIR   resources\Icons;
MKDIR   resources\Reports;
MKDIR   resources\Ocx;
COPY  /Y  %1resources\*.* resources;
COPY /Y %1resources\Reports\*.* resources\Reports;
COPY /Y %1resources\Icons\*.* resources\Icons;
COPY /Y %1resources\Ocx\*.* resources\Ocx;
COPY /Y %1lib\*.dll lib;
DEL  *.pdb ;
DEL  Janus*.dll ;
DEL  *Interop*.dll ;
MOVE  *mz*.dll Assemblies;
MOVE  *.dll lib;
DEL  mz*.xml ;
DEL  Janus*.xml;
DEL ClassLibrary1.xml;
REM MOVE   Assemblies\AssemblyRebinding.xml \;
REM MOVE  Assemblies\mz.erp.ui.dll 

 


