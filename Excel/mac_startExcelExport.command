#!/bin/bash
curPath=$( cd "$( dirname "${BASH_SOURCE[0]}" )" && pwd )
cd $curPath/../Bin
dotnet Tools.dll --AppType=ExcelExporter