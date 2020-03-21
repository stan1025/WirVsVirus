"%~dp0..\tools\thrift-0.13.0.exe" -r --gen netstd "%~dp0thrift-defs\Types.thrift"
"%~dp0..\tools\thrift-0.13.0.exe" -r --gen netstd  "%~dp0thrift-defs\RequestDataService.thrift"
"%~dp0..\tools\thrift-0.13.0.exe" -r --gen netstd  "%~dp0thrift-defs\SendSymptomeService.thrift"
"%~dp0..\tools\thrift-0.13.0.exe" -r --gen netstd  "%~dp0thrift-defs\ResponseDataService.thrift"
"%~dp0..\tools\thrift-0.13.0.exe" -r --gen js:node "%~dp0thrift-defs\Types.thrift"
"%~dp0..\tools\thrift-0.13.0.exe" -r --gen js:node "%~dp0thrift-defs\RequestDataService.thrift"
"%~dp0..\tools\thrift-0.13.0.exe" -r --gen js:node "%~dp0thrift-defs\SendSymptomeService.thrift"
"%~dp0..\tools\thrift-0.13.0.exe" -r --gen js:node "%~dp0thrift-defs\ResponseDataService.thrift"
pause