# SignYouOut

SignYouOut is a simple Windows app that logs out other users using [Cassia](https://github.com/danports/cassia).

This is useful when you have two people using the same computer, and you want to sign them out automatically when you log in.

## Other strategies

[Most](https://gallery.technet.microsoft.com/scriptcenter/Get-UserSessions-Parse-b4c97837)
[solutions](https://stackoverflow.com/a/18193461/771768)
I've seen use `quser.exe`. but `quser.exe` (and `query.exe user`) is
[not avaliable](https://docs.microsoft.com/en-us/windows-server/administration/windows-commands/query-user) on Windows 10 Home.
Simply copying it [isn't a good idea.](https://superuser.com/a/509009/282374)

In the [webserver](../../tree/webserver) branch, I first created a simple Windows web server that listens to POST requests and logs out the current user.
But once I found Cassia that was more complicated than necessary.
