# pasteascsv
Copy and paste SQL GUIDs as comma-separated values. Values are escaped with single quotes, handy to use with IN clause. Single quotes in strings are escaped as well.

## Installing
Download the latest [release](https://github.com/HMLd/pasteascsv/releseases) and unzip the ZIP to Management Studio’s extensions folder (Full path will be c:\Program Files (x86)\Microsoft SQL Server Management Studio 18\Common7\IDE\Extensions\CSV\) and restart SSMS

## How to use
Execute a query in the SSMS query window, copy results, right click and select "Paste as CSV" from context menu.

[Screenshot 1](Docs/Screenshot1.jpeg)

Results will be pasted as single-quoted, comma-separated values

[Screenshot 2](Docs/Screenshot2.jpeg)