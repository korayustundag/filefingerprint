using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFingerprint
{
    public class HtmlBuilder
    {
        private StringBuilder _StringBuilder = new StringBuilder();

        public HtmlBuilder()
        {
            _StringBuilder.AppendLine(@"
<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Fingerprint Report</title>
    <style>
        body{
            margin-top: 20px;
            margin-bottom: 20px;
            margin-left: 20px;
            margin-right: 20px;
        }
        h1{
            text-align: center;
        }
        table, th, td {
            border:1px solid black;
        }
    </style>
</head>
<body>
    <h1>Fingerprint Report</h1>
    <table style=""width: 100%"">
        <tr>
            <th>File Name</th>
            <th>File Size</th>
            <th>Creation Date</th>
            <th>Fingerprint</th>
        </tr>
");
        }

        public void Add(string[] data)
        {
            _StringBuilder.AppendLine("        <tr>");
            _StringBuilder.AppendLine("            <th style=\"font-weight: normal;\">" + data[0] + "</th>");
            _StringBuilder.AppendLine("            <th style=\"font-weight: normal;\">" + data[1] + "</th>");
            _StringBuilder.AppendLine("            <th style=\"font-weight: normal;\">" + data[2] + "</th>");
            _StringBuilder.AppendLine("            <th style=\"font-weight: normal;\">" + data[3] + "</th>");
            _StringBuilder.AppendLine("        </tr>");
        }

        public string Build()
        {
            _StringBuilder.AppendLine(@"
    </table>
</body>
");
            return _StringBuilder.ToString();
        }
    }
}
