IF EXIST packages (IF EXIST packages\Bunifu.UI.WinForms.5.0.6\lib\Bunifu.Licensing.dll DEL /F packages\Bunifu.UI.WinForms.5.0.6\lib\Bunifu.Licensing.dll
copy  "Bunifu.Licensing.dll"  "packages\Bunifu.UI.WinForms.5.0.6\lib"
IF EXIST packages\Bunifu.Dataviz.WinForms.2.1.6\lib\Bunifu.Licensing.dll DEL /F packages\Bunifu.Dataviz.WinForms.2.1.6\lib\Bunifu.Licensing.dll
copy  "Bunifu.Licensing.dll"  "packages\Bunifu.Dataviz.WinForms.2.1.6\lib"
IF EXIST packages\Bunifu.Licensing.5.0.0\lib\net6.0-windows7.0\Bunifu.Licensing.dll DEL /F packages\Bunifu.Licensing.5.0.0\lib\net6.0-windows7.0\Bunifu.Licensing.dll
copy  "Bunifu.Licensing.dll"  "packages\Bunifu.Licensing.5.0.0\lib\net6.0-windows7.0\"
IF EXIST packages\Bunifu.Licensing.5.0.0\lib\net40\Bunifu.Licensing.dll DEL /F packages\Bunifu.Licensing.5.0.0\lib\net40\Bunifu.Licensing.dll
copy  "Bunifu.Licensing.dll"  "packages\Bunifu.Licensing.5.0.0\lib\net40\") ELSE  @echo off echo Para copiar se necesita compilar
