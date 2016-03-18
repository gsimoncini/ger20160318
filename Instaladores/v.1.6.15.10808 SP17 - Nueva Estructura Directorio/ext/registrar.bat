copy winfis32.dll c:\windows\system32
copy Fiscal051122.ocx c:\windows\system32
copy IFEpson.ocx c:\windows\system32
copy hasar320.ocx c:\windows\system32

GO

c:\windows\system32\regsvr32 winfis32.dll /s
c:\windows\system32\regsvr32 hasar320.ocx
c:\windows\system32\regsvr32 IFEpson.ocx
c:\windows\system32\regsvr32 Fiscal051122.ocx

GO