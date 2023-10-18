
# NetScan
Application that allows you to scan a network of interest by identifying active devices. Furthermore, it allows you to indicate a list of ports that will be checked on active devices on the network.
Application that allows you to scan a network of interest by identifying active devices. Furthermore, it allows you to indicate a list of ports that will be checked on active devices on the network.

### Known ports
| Porta | TCP | UDP | Nome | Descrizione |
|-------|-----|-----|------|-------------|
| 1     | ✔   | ✔   | tcpmux | TCP Port Multiplexer |
| 5     | ✔   | ✔   | rje | Remote Job Entry (Inserimento lavoro remoto) |
| 7     | ✔   | ✔   | echo | Servizio Echo |
| 9     | ✔   | ✔   | discard | Servizio zero a scopo di test |
| 11    | ✔   | ✔   | systat | Informazioni di sistema |
| 13    | ✔   | ✔   | daytime | Indicazioni di data e ora |
| 17    | ✔   | ✔   | qotd | Invia la citazione del giorno |
| 18    | ✔   | ✔   | msp | Trasmette messaggi di testo |
| 19    | ✔   | ✔   | chargen | Invia una stringa infinita |
| 20    | ✔   |     | ftp-data | Trasmissione di dati FTP |
| 21    | ✔   | ✔   | ftp | Collegamento FTP |
| 22    | ✔   | ✔   | ssh | Secure Shell Service |
| 23    | ✔   |     | telnet | Servizio Telnet |
| 25    | ✔   |     | smtp | Simple Mail Transfer Protocol |
| 37    | ✔   | ✔   | time | Protocollo di tempo leggibile meccanicamente |
| 39    | ✔   | ✔   | rlp | Resource Location Protocol |
| 42    | ✔   | ✔   | nameserver | Servizio nome |
| 43    | ✔   |     | nicname | Servizio di directory WHOIS |
| 49    | ✔   | ✔   | tacacs | Terminal Access Controller Access Control System |
| 50    | ✔   | ✔   | re-mail-ck | Remote Mail Checking |
| 53    | ✔   | ✔   | domain | Risoluzione nome tramite DNS |
| 67    |     | ✔   | bootps | Bootstrap Protocol Services |
| 68    |     | ✔   | bootpc | Bootstrap Client |
| 69    |     | ✔   | tftp | Trivial File Transfer Protocol |
| 70    | ✔   |     | gopher | Ricerca di documenti |
| 71    | ✔   |     | genius | Protocollo genio |
| 79    | ✔   |     | finger | Fornisce informazioni di contatto degli utenti |
| 80    | ✔   |     | http | Hypertext Transfer Protocol |
| 81    | ✔   |     |      | Torpark: Onion-Routing (non ufficiale) |
| 82    |     | ✔   |      | Torpark: Control (non ufficiale) |
| 88    | ✔   | ✔   | kerberos | Sistema di autenticazione di rete |
| 101   | ✔   |     | hostname | NIC Host Name |
| 102   | ✔   |     | Iso-tsap | ISO-TSAP-Protocol |
| 105   | ✔   | ✔   | csnet-ns | Mailbox-Mailserver |
| 107   | ✔   |     | rtelnet | Remote Telnet |
| 109   | ✔   |     | pop2 | Post Office Protocol v2 per la comunicazione e-mail |
| 110   | ✔   |     | pop3 | Post Office Protocol v3 per la comunicazione e-mail |
| 111   | ✔   | ✔   | sunrpc | Protocollo RPC per NFS |
| 113   |     | ✔   | auth | Servizio di autenticazione |
| 115   | ✔   |     | sftp | Simple File Transfer Protocol (versione semplice di FTP) |
| 117   | ✔   |     | uucp-path | Trasmissione di dati tra sistemi Unix |
| 119   | ✔   |     | nntp | Trasmissione di messaggi in newsgroup |
| 123   |     | ✔   | ntp | Servizio di sincronizzazione temporale |
| 137   | ✔   | ✔   | netbios-ns | NETBIOS Name Service |
| 138   | ✔   | ✔   | netbios-dgm | NETBIOS Datagram Service |
| 139   | ✔   | ✔   | netbios-ssn | NETBIOS Session Service |
| 143   | ✔   | ✔   | imap | Internet Message Access Protocol per comunicazione e-mail |
| 161   |     | ✔   | snmp | Simple Network Management Protocol |
| 162   | ✔   | ✔   | snmptrap | Simple Network Management Protocol Trap |
| 177   | ✔   | ✔   | xdmcp | X Display Manager |
| 179   | ✔   |     | bgp | Border Gateway Protocol |
| 194   | ✔   | ✔   | irc | Internet Relay Chat |
| 199   | ✔   | ✔   | smux | SNMP UNIX Multiplexer |
| 201   | ✔   | ✔   | at-rtmp | AppleTalk Routing |
| 209   | ✔   | ✔   | qmtp | Quick Mail Transfer Protocol |
| 210   | ✔   | ✔   | z39.50 | Sistema di informazioni bibliografiche |
| 213   | ✔   | ✔   | ipx | Internetwork Packet Exchange |
| 220   | ✔   | ✔   | imap3 | IMAP v3 per la comunicazione e-mail |
| 369   | ✔   | ✔   | rpc2portmap | Coda Filesystem Portmapper |
| 370   | ✔   | ✔   | codaauth2 | Coda Filesystem Authentication Service |
| 389   | ✔   | ✔   | ldap | Lightweight Directory Access Protocol |
| 427   | ✔   | ✔   | svrloc | Service Location Protocol |
| 443   | ✔   |     | https | HTTPS (HTTP tramite SSL/TLS) |
| 444   | ✔   | ✔   | snpp | Simple Network Paging Protocol |
| 445   | ✔   |     | microsoft-ds | SMB tramite TCP/IP |
| 464   | ✔   | ✔   | kpasswd | Modifica password per Kerberos |
| 500   |     | ✔   | isakmp | Protocollo di sicurezza |
| 512   | ✔   |     | exec | Remote Process Execution |
| 512   |     | ✔   | comsat/biff | Client e server di posta |
| 513   | ✔   |     | login | Accesso a computer remoto |
| 513   |     | ✔   | who | Whod User Logging Daemon |
| 514   | ✔   |     | shell | Remote Shell |
| 514   |     | ✔   | syslog | Unix System Logging Service |
| 515   | ✔   |     | printer | Servizi di stampa Line Printer Daemon |
| 517   |     | ✔   | talk | Talk Remote Calling |
| 518   |     | ✔   | ntalk | Network Talk |
| 520   | ✔   |     | efs | Extended Filename Server |
| 520   |     | ✔   | router | Routing Information Protocol |
| 521   |     | ✔   | ripng | Routing Information Protocol per IPv6 |
| 525   |     | ✔   | timed | Server dell'ora |
| 530   | ✔   | ✔   | courier | Courier Remote Procedure Call |
| 531   | ✔   | ✔   | conference | Chat tramite AIM e IRC |
| 532   | ✔   |     | netnews | Netnews Newsgroup Service |
| 533   |     | ✔   | netwall | Broadcast d'emergenza |
| 540   | ✔   |     | uucp | Unix-to-Unix Copy Protocol |
| 543   | ✔   |     | klogin | Kerberos v5 Remote Login |
| 544   | ✔   |     | kshell | Kerberos v5 Remote Shell |
| 546   | ✔   | ✔   | dhcpv6-client | DHCP v6 Client |
| 547   | ✔   | ✔   | dhcpv6-server | DHCP v6 Server |
| 548   | ✔   |     | afpovertcp | Apple Filing Protocol tramite TCP |
| 554   | ✔   | ✔   | rtsp | Comando di streams |
| 556   | ✔   |     | remotefs | Remote Filesystem |
| 563   | ✔   | ✔   | nntps | NNTP tramite SSL/TLS |
| 587   | ✔   |     | submission | Message Submission Agent |
| 631   | ✔   | ✔   | ipp | Internet Printing Protocol |
| 631   | ✔   | ✔   |      | Common Unix Printing System (non ufficiale) |
| 636   | ✔   | ✔   | ldaps | LDAP tramite SSL/TLS |
| 674   | ✔   |     | acap | Application Configuration Access Protocol |
| 694   | ✔   | ✔   | ha-cluster | Servizio Heartbeat |
| 749   | ✔   | ✔   | kerberos-adm | Kerberos v5 Administration |
| 750   |     | ✔   | kerberos-iv | Kerberos v4 Services |
| 873   | ✔   |     | rsync | Servizi di trasferimento file rsync |
| 992   | ✔   | ✔   | telnets | Telnet tramite SSL/TLS |
| 993   | ✔   |     | imaps | IMAP tramite SSL/TLS |
| 995   | ✔   |     | pop3s | POP3 tramite SSL/TLS |

### Registered ports
| Porta  | TCP | UDP | Nome          | Descrizione                                          |
|--------|-----|-----|---------------|------------------------------------------------------|
| 1080   | ✔   |     | socks         | SOCKS Proxy                                          |
| 1433   | ✔   |     | ms-sql-s      | Microsoft SQL Server                                |
| 1434   | ✔   | ✔   | ms-sql-m      | Microsoft SQL Monitor                                |
| 1494   | ✔   |     | ica           | Citrix ICA Client                                    |
| 1512   | ✔   | ✔   | wins          | Windows Internet Name Service                        |
| 1524   | ✔   | ✔   | ingreslock    | Ingres DBMS                                          |
| 1701   |     | ✔   | l2tp          | Layer 2 Tunneling Protocol / Layer 2 Forwarding    |
| 1719   |     | ✔   | h323gatestat  | H.323                                               |
| 1720   | ✔   |     | h323hostcall  | H.323                                               |
| 1812   | ✔   | ✔   | radius        | Autenticazione RADIUS                               |
| 1813   | ✔   | ✔   | radius-acct   | Accesso RADIUS                                       |
| 1985   |     | ✔   | hsrp          | Cisco HSRP                                          |
| 2008   | ✔   |     |               | Teamspeak 3 Accounting (non ufficiale)             |
| 2010   |     | ✔   |               | Teamspeak 3 Weblist (non ufficiale)                 |
| 2049   | ✔   | ✔   | nfs           | Network File System                                  |
| 2102   | ✔   | ✔   | zephyr-srv    | Zephyr Server                                        |
| 2103   | ✔   | ✔   | zephyr-clt    | Zephyr Client                                        |
| 2104   | ✔   | ✔   | zephyr-hm     | Zephyr Host Manager                                  |
| 2401   | ✔   |     | cvspserver    | Concurrent Versions System                           |
| 2809   | ✔   | ✔   | corbaloc      | Common Object Request Broker Architecture           |
| 3306   | ✔   | ✔   | mysql         | Servizio di banca dati MySQL (anche per MariaDB)    |
| 4321   | ✔   |     | rwhois        | Remote Whois Service                                 |
| 5999   | ✔   |     | cvsup         | CVSup                                               |
| 6000   | ✔   |     | X11           | X Windows System Services                            |
| 11371  | ✔   |     | pgpkeyserver  | Keyserver pubblico per PGP                            |
| 13720  | ✔   | ✔   | bprd          | Symantec/Veritas NetBackup                          |
| 13721  | ✔   | ✔   | bpbm          | Symantec/Veritas Database Manager                    |
| 13724  | ✔   | ✔   | vnetd         | Symantec/Veritas Network Utility                    |
| 13782  | ✔   | ✔   | bpcd          | Symantec/Veritas NetBackup                          |
| 13783  | ✔   | ✔   | vopied        | Symantec/Veritas VOPIE                               |
| 22273  | ✔   | ✔   | wnn6          | Conversione Kana/Kanji                               |
| 23399  |     |     |               | Skype (non ufficiale)                                |
| 25565  | ✔   |     |               | Minecraft                                            |
| 26000  | ✔   | ✔   | quake         | Quake e altri giochi a più giocatori               |
| 27017  |     |     |               | MongoDB                                              |
| 33434  | ✔   | ✔   | traceroute    | Tracking di rete                                      |


###### Ports 49152 and above are dynamic ports. These are not assigned by IANA. Each application can use this port locally or dynamically globally. So it can easily happen that one of these ports is already occupied.
