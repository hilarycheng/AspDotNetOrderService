#!/bin/bash
#

 ~/.dotnet/tools/dotnet-ef dbcontext scaffold "server=localhost;uid=hongwei;pwd=123456;database=hwdb" MySql.EntityFrameworkCore -o Models
