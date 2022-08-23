namespace NetworkThesaurus
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey PressNotEsc;

            do
            {
                Console.Clear();
                Console.WriteLine("-------------------------");
                Console.WriteLine("1) Se liste");
                Console.WriteLine("2) Tilføj begreb(WIP)");
                Console.WriteLine("3) Redigér begreb(IKKE TILGÆNGELIGT)");
                Console.WriteLine("4) Fjern begreb (IKKE TILGÆNGELIGT)");
                Console.WriteLine("-------------------------");

                string MenuNumber = (Console.ReadLine());

                if (MenuNumber == "1")
                {
                    Console.Clear();
                    TermList();
                }
                else if (MenuNumber == "2")
                {   // Indtastning af Nyt begreb + besrkivelse + kategori
                    Console.Clear();
                    Console.WriteLine("Skriv nedenunder et begreb som skal tilføjes");
                    Console.WriteLine("------------------------");
                    Console.WriteLine("TILFØJ BEGREB");
                    Console.WriteLine("------------------------");
                    List<Network_Thesaurus.ThessaurusDatabase> Termlist = new List<Network_Thesaurus.ThessaurusDatabase>();
                    do
                    {
                        Console.WriteLine("Skriv Navn, beskrivelse og kategori ind. Skriv ''stopservice'' for at afslutte");
                        string tname = Console.ReadLine();
                        if (tname.ToLower() == "stopservice")
                        {
                            break;
                        }
                        string tdisc = Console.ReadLine();
                        string tcat = Console.ReadLine();

                        Termlist.Add(new Network_Thesaurus.ThessaurusDatabase(tname, tdisc, tcat));

                        Console.WriteLine($"Begreb {Termlist[Termlist.Count - 1].TermName} blev tilføjet til begrebslisten.");

                        string resultat = Termlist[0].TermName;



                    } while (true);

                    // Søgefunktion
                    /*
                    foreach (Network_Thesaurus.ThessaurusDatabase term in Termlist)
                    {
                        if (term.TermName == "PC")
                        {
                            Console.WriteLine($"termName: {term.TermName}. TermDisk:");
                        }
                    }
                    */
                }
                else if (MenuNumber == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Denne del er stadig under konstruktion. Prøv en anden menu.");
                    Console.WriteLine("Gå tilbage med r. Ellers afslut med anden vilkårig tast.");
                    string EndorReturn = Console.ReadLine();
                    if (EndorReturn == "r")
                    {
                        return;
                    }
                    else if (EndorReturn != "r")
                    {
                        Environment.Exit(0);
                    }
                }
                else if (MenuNumber == "4")
                {
                    Console.Clear();
                    Console.WriteLine("Denne del er stadig under konstruktion. Prøv en anden menu.");
                    Console.WriteLine("Gå tilbage med r. Ellers afslut med anden vilkårig tast.");
                    string EndorReturn = Console.ReadLine();
                    if (EndorReturn == "r")
                    {
                        return;
                    }
                    else if (EndorReturn != "r")
                    {
                        Environment.Exit(0);
                    }
                }
                else if (MenuNumber != "1" & MenuNumber != "2" & MenuNumber != "3" & MenuNumber != "4")
                {
                    Environment.Exit(0);
                }
                PressNotEsc = Console.ReadKey().Key;
            }
            while (PressNotEsc != ConsoleKey.Escape);
        }
        static void TermList()
        {
            Console.Clear();
            Console.WriteLine("Skriv nedenfor et keyword, eks. 1 = physical layer, org = organisationer ");
            Console.WriteLine("------------------------");
            Console.WriteLine("BEGREBSLISTE");
            Console.WriteLine("------------------------");
            Console.WriteLine("Generel Information (gi)");
            Console.WriteLine("Organisationer (org)");
            Console.WriteLine("Konsol (kon)");
            Console.WriteLine("---------");
            Console.WriteLine("Layers:");
            Console.WriteLine("(1) Physical Layer");
            Console.WriteLine("(2) Data-Link Layer");
            Console.WriteLine("(3) Network Layer");
            Console.WriteLine("(4) Transport Layer");
            Console.WriteLine("(5) Session Layer");
            Console.WriteLine("(6) Presentation Layer");
            Console.WriteLine("(7) Application Layer");
            Console.WriteLine("(0) Tilbage");
            Console.WriteLine("------------------------");
            string InputSubject = Console.ReadLine();

            if (InputSubject == "r")
            {
                return;
            }
            else if (InputSubject == "1")
            {
                Console.Clear();
                Console.WriteLine("indtast r for at vende et skridt tilbage. e for at afslutte. ");
                Console.WriteLine("-----------------------:");
                Console.WriteLine("Lag 1: PHYSICAL");
                Console.WriteLine("-----------------------:");
                Console.WriteLine();
                Console.WriteLine("NIC: Network interface controller. Netværks-adapter. Indeholder protokoller og " +
                    "sørger for forbindelsen mellem det fysiske og data-link lagene.");
                Console.WriteLine();
                Console.WriteLine("---- Fysisk udstyr ----: ");
                Console.WriteLine();
                Console.WriteLine("RJ-45: konsol-kabel til at tilgå routerens konsol");
                Console.WriteLine();
                Console.WriteLine("COAX: ");
                Console.WriteLine();
                Console.WriteLine("FIBER OPTISK KABEL: Anvender lys til at sende signaler. Høj hastighed over lange forbindelser." +
                    "Mindre forstyrrelser (ingen elektromagnetisk støj), men dyrt og ikke nær så fleksibelt.");
                Console.WriteLine();
                Console.WriteLine("KOPPER-KABLER: Billigt og relativt fleksibelt, men dog sårbart overfor forstyrrelser som EMI (elektromagnetisk støj). " + "Kabel-typer:" +
                    "\n 1) UTP: Untwisted Pair kabel. " +
                    "\n 2) Twisted Pair kabel");
                Console.WriteLine();
                Console.WriteLine("WLAN: Wireless Local area network. Anvender radiobølger, der kan være meget sårbare overfor støj (frekvensen 2.4 Ghz er anvendt til mange formål, " +
                    "5 Ghz har ikke nær så lang bredde), men giver til gengæld mobilitet.");
                Console.WriteLine();
                Console.WriteLine("PowerLine: En løsning hvor en netværksadapter sættes i stikkontakter og " +
                    "bruger det interne kredsløb til at sende signal til en anden powerline adapter. Kan opleve forstyrrelser fra andet udstyr med højt strømforbrug");
                Console.WriteLine();
                Console.WriteLine("ISP: Internet service provider / internetudbyder.");
                Console.WriteLine();
                Console.WriteLine("Wireless Broadband: Alternativ, trådløs forbindelse fra udbyder (WISP), der sender signal fra master o.lign.");
                Console.WriteLine();
                Console.WriteLine("LAN: Local Area Network");
                Console.WriteLine();
                Console.WriteLine("WAN: Wide Area Network");
                Console.WriteLine();
                Console.WriteLine("DSL: Digital subscriber line. Netværkstrafik foregår gennem telefon-linjen. Ikke anvendt længere.");
                Console.WriteLine();
                Console.WriteLine("---- Tekniske begreber ----: ");
                Console.WriteLine("ENCODING: Metode hvorved en strøm af bits oversættes til specifik kode, " +
                    "således at det kan oversættes af andre enheder. Kan sammenlignes med morsekode. Et simpelt eksempel er Manchester encoding.");
                Console.WriteLine();
                Console.WriteLine("SIGNALING: elektrisk, optisk eller trådløst(radiobølger) signal der repræsenterer 0 og 1. De bits der er repræsenteret kaldes signaling. method.");
                Console.WriteLine();
                Console.WriteLine("BANDWIDTH: Hvor mange bits der kan sendes i sekundet. Herunder:" +
                    "\n 1) bps (Bits per second). 1 bps = fundamental unit of bandwidth" +
                    "\n 2) Kbps (Kilobits per second). 1 Kbps = 1,000 bps = 10^3 bps" +
                    "\n 3) Mbps (Megabits per second). 1 Mbps = 1,000,000 bps = 10^6 bps" +
                    "\n 4) Gbps (Gigabits per second). 1 Gbps = 1,000,000,000 bps = 10^9 bps" +
                    "\n 5) Tbps (Terabits per second). 1 Tbps = 1,000,000,000,000 bps = 10^12 bps");
                Console.WriteLine();
                Console.WriteLine("-----------Bandwidth termonologi-----------" +
                    "\n Latency: Den tid samt forsinkelse for data at rejse fra et sted til et andet. " +
                    "Forsendelsen er påvirket af det 'svageste led', der skaber flaskehals hvis den er med i den rute, data sendes gennem." +
                    "\n Throughput: " +
                    "\n Goodput: ");

                string WaitForInput = Console.ReadLine();
                if (WaitForInput == "r")
                {
                    TermList();
                }
                else if (WaitForInput == "e")
                {
                    Environment.Exit(0);
                }

            }
            if (InputSubject == "2")
            {
                Console.Clear();
                Console.WriteLine("-----------------------:");
                Console.WriteLine("Lag 2: PACKET");
                Console.WriteLine("-----------------------:");
                Console.WriteLine("indtast r for at vende et skridt tilbage. e for at afslutte. ");
                string WaitForInput2 = Console.ReadLine();
                if (WaitForInput2 == "r")
                {
                    TermList();
                }
                else if (WaitForInput2 == "e")
                {
                    Environment.Exit(0);

                }
            }
            if (InputSubject == "3")
            {
                Console.Clear();
                Console.WriteLine("-----------------------:");
                Console.WriteLine("Lag 3: NETWORK");
                Console.WriteLine("-----------------------:");
                Console.WriteLine("SLAAC: Stateless Address Auto-configuration. Ingen server holder styr på assigned IP-adresser (hvem er hvem på netværk), " +
                    "og det lagres ikke i routere. RFC 4862.");
                Console.WriteLine("indtast r for at vende et skridt tilbage. e for at afslutte. ");
                string WaitForInput3 = Console.ReadLine();
                if (WaitForInput3 == "r")
                {
                    TermList();
                }
                else if (WaitForInput3 == "e")
                {
                    Environment.Exit(0);
                }
            }
            if (InputSubject == "4")
            {
                Console.Clear();
                Console.WriteLine("-----------------------:");
                Console.WriteLine("Lag 4: TRANSPORT");
                Console.WriteLine("-----------------------:");
                Console.WriteLine("TCP: Transmission control Protocol. Høj sikkerhed og flow control, men vil også have højere delay, grundet de ekstra" +
                    "protokoller, der sikrer at data er sendt/modtaget ordentligt (eks. databaser, website, e-mails, on-demand-video). TCP er en Connection-oriented protocol/stateful, " +
                    "og header anvender 20 bytes/160 bits til protocol overheard. Stikord: " +
                    "Establishes Session, Ensures reliable delivery, Provides Same-order delivery, supports flow control. Se RFC 793 for mere.");
                Console.WriteLine();
                Console.WriteLine("UDP: User datagram Protocol.connectionless protocol. Ingen reliability eller flow control som ved TCP. Holder ikke øje med " +
                    "hvorledes data er sendt eller modtaget, og informerer ikke om dette. Godt at benytte til ting der ikke kræver stor 'sikkerhed', men " +
                    "i højere grad hastighed (eks. VOIP eller videostream). DNS anvender UDP, da den blot vil sende en request igen, hvis den ikke får svar af DNS'en. UDP er en " +
                    "Stateless Protocol og header anvender 8 bytes/64 bits til protocol overhead. Stikord: No reliability, Faster speeds, Lost segments not resent, " +
                    "no session establishment, data recontructed in recieved order/unchecked order, applications with self-maintained flow control (SNMP and TFTP).");
                Console.WriteLine();
                Console.WriteLine("Segmentation: data opdeles i og består af segmenter.");
                Console.WriteLine();
                Console.WriteLine("Conversation multiplexing: Giver mulighed for at sende mange forskellige data til forskellige porte på samme tid, hvor dele af forskellige" +
                    "data sendes sammen.");
                Console.WriteLine();
                Console.WriteLine("Three-way handshake: (UNIT1) SYN->ACK (UNIT2) (UNIT2) SYN -> ACK (UNIT1) ");
                Console.WriteLine();
                Console.WriteLine("------ TCP kommunikationsstruktur ------");
                Console.WriteLine();
                Console.WriteLine("ACK: Ackknowledgement. Del af three-part-handshake protokollen for TCP forbindelse. Etablerer forbindelsen. Validerer forbindelsenog evnen til at kommunikere for modtager");
                Console.WriteLine();
                Console.WriteLine("SYN: Synchronization. Del af three-part-handshake protokollen for TCP forbindelse. Validerer forbindelsen og evnen til at kommunikere for modtager ");
                Console.WriteLine();
                Console.WriteLine("RST: Nulstiller.");
                Console.WriteLine();
                Console.WriteLine("FIN: Sidste del af three-part-handshake protokollen for TCP forbindelse. Sender besked til modtager om at forbindelsen er afbrudt");
                Console.WriteLine();
                Console.WriteLine("SEQ: Sequence for TCP");
                Console.WriteLine();
                Console.WriteLine("SACK: Selective ackknowledgement. Kan anmode om at modtage specifikke dele af data, hvis ikke det er modtaget ordentligt. " +
                    "Giver hurtigere datahastighed. Skal dog være understøttet.!");
                Console.WriteLine();
                Console.WriteLine("------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("ISN: Initial sequence number.");
                Console.WriteLine();
                Console.WriteLine("Sliding Windows Protocol: Mogtager vil typisk sende en ACK efter hver anden segment den har modtaget. " +
                    "Dette kan skifte. Fordelen ved dette er, at det giver mulighed for at sender løbende (og vedvarende) kan sende segmenter" +
                    "Så længe at modtageren har godkendt det tidligere segmenter.");
                Console.WriteLine();
                Console.WriteLine("MSS: maximum segment size. Største segmentstørrelse der kan modtages. Typisk 1460 bytes i et segment (IPv4). Typsik medfølgende i et three-way-handshake.");
                Console.WriteLine();
                Console.WriteLine("MTU; Maximum transmission unit (Ethernet). Default er 1500 max bytes i et segment.");
                Console.WriteLine();
                Console.WriteLine("URG: urgent pointer field significant");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("TCP Congestion Avoidance/congestion control: Flow control. For at undgå packet loss ved router overload, er der indbygget algoritmer, som gør" +
                    " at hvis ikke nok packets i TCP får godkendelse (ack), så vil der automatisk ske en reduktion på bytes der sendes, før der er modtaget en ackknowledgement.");
                Console.WriteLine("Socket (Cisco): Port nummber + IP-adresse.");
                Console.WriteLine("Port number group: Well-known ports: 0-1,023. Registered Ports: 1024 48151, Private and/or Dynamic ports: 65535. " +
                    "Vigtigste/velkendte ift. til CISCO: port 20-25, 53, 67-69, 80, 110, 143, 161, 443.");
                Console.WriteLine("Radius server: Information omkring log-in lagret på en server, så man nemmere kan få til");
                Console.WriteLine("indtast r for at vende et skridt tilbage. e for at afslutte. "); // afsluttende - skriv altid til sidst
                string WaitForInput4 = Console.ReadLine();
                if (WaitForInput4 == "r")
                {
                    TermList();
                }
                else if (WaitForInput4 == "e")
                {
                    Environment.Exit(0);
                }
            }
            if (InputSubject == "5")
            {
                Console.Clear();
                Console.WriteLine("-----------------------:");
                Console.WriteLine("Lag 5: SESSION: ");
                Console.WriteLine("-----------------------:");
                Console.WriteLine("indtast r for at vende et skridt tilbage. e for at afslutte. "); // afsluttende - skriv altid til sidst
                string WaitForInput5 = Console.ReadLine();
                if (WaitForInput5 == "r")
                {
                    TermList();
                }
                else if (WaitForInput5 == "e")
                {
                    Environment.Exit(0);

                }
            }
            if (InputSubject == "6")
            {
                Console.Clear();
                Console.WriteLine("-----------------------:");
                Console.WriteLine("Lag 6: PRESENTATION:");
                Console.WriteLine("-----------------------:");
                Console.WriteLine("indtast r for at vende et skridt tilbage. e for at afslutte. "); // afsluttende - skriv altid til sidst
                string WaitForInput6 = Console.ReadLine();
                if (WaitForInput6 == "r")
                {
                    TermList();
                }
                else if (WaitForInput6 == "e")
                {
                    Environment.Exit(0);
                }

            }
            if (InputSubject == "7")
            {
                Console.Clear();
                Console.WriteLine("-----------------------:");
                Console.WriteLine("Lag 7: APPLICATION:");
                Console.WriteLine("-----------------------:");
                Console.WriteLine();
                Console.WriteLine("DNS: Domain Name System.");
                Console.WriteLine();
                Console.WriteLine("DHCP: Dynamic Host Configuration Protocol.");
                Console.WriteLine();
                Console.WriteLine("FTP");
                Console.WriteLine();
                Console.WriteLine("TFTP: ");
                Console.WriteLine();
                Console.WriteLine("P2P: Peer-to-peer. ");
                Console.WriteLine();
                Console.WriteLine("TCP: Transmission Control Protocol.");
                Console.WriteLine();
                Console.WriteLine("Client-Server Model: ");
                Console.WriteLine();
                Console.WriteLine("HTTP/HTTPS: ");
                Console.WriteLine();
                Console.WriteLine("SMTP: ");
                Console.WriteLine();
                Console.WriteLine("POP3: ");
                Console.WriteLine();
                Console.WriteLine("IMAP: ");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("indtast r for at vende et skridt tilbage. e for at afslutte. "); // afsluttende - skriv altid til sidst
                string WaitForInput7 = Console.ReadLine();
                if (WaitForInput7 == "r")
                {
                    TermList();
                }
                else if (WaitForInput7 == "e")
                {
                    Environment.Exit(0);
                }
            }
            if (InputSubject == "0")
            {
                Console.Clear();
                return;
            }
            if (InputSubject == "gi")
            {
                Console.Clear();
                Console.WriteLine("-----------------------:");
                Console.WriteLine("GENEREL INFORMATION");
                Console.WriteLine("-----------------------:");
                Console.WriteLine();
                Console.WriteLine("Fault tolerance: Hvorvidt netværket er sikret, skulle mellemled (routere, switches, etc.) fejle. Dette sikrer man f.eks. ved" +
                " at sørge for flere veje gennem netværket gennem f.eks. switches/routere.");
                Console.WriteLine();
                Console.WriteLine("Scalability: Hvor vidt netværket understøtter udvidelse, såsom flere enheder, flere afdelinger, etc.");
                Console.WriteLine();
                Console.WriteLine("QoS: Quality of Service. Omhandler prioritet af data, således at mindre vigtig data" +
                " (som generel video-streaming, e-mails etc.), ikke blokerer andet, vigtigere data. Prioriteten kan på de fleste netværk ændres efter behov.");
                Console.WriteLine();
                Console.WriteLine("Network Security: Sikkerhed spiller en stor rolle i nutidens IT-løsninger. Dette er et vigtigt punkt at overveje og sikre i alle netværksløsninger.");
                Console.WriteLine();
                Console.WriteLine("BYOD: Bring-your-own-device. Sikrer at netværket understøtter, at brugere kan anvende deres egne enheder på netværket.");
                Console.WriteLine();
                Console.WriteLine("IOS: Ikke at forveksle med Apples styresystem (iOS). Cisco specifik interface til at arbejde med netværk. ");
                Console.WriteLine();
                Console.WriteLine("CLI: Console Line Interface. Benytter konsol-brugerflade med tekst-baseret navigation og ordrer (commands). Typisk anvendt af IT-eksperter");
                Console.WriteLine();
                Console.WriteLine("GUI: Graphical User Interface. Benytter en grafisk brugerflade som mellemled mellem router og bruger, med mere" +
                " visuelle elementer, der kan gøre processen mere overskuelig. (typisk til hjemmenetværksroutere)");
                Console.WriteLine();
                Console.WriteLine("Extranet: Et netværk der også er forbundet med andre, f.eks. en virksomheds leverandører.");
                Console.WriteLine();
                Console.WriteLine("Intranet: Et netværk der kun er forbundet i et isoleret, internt miljø");
                Console.WriteLine("---------------:");
                Console.WriteLine("NETVÆRKSIKKERHED");
                Console.WriteLine("---------------:");
                Console.WriteLine();
                Console.WriteLine("");
                Console.WriteLine();
                Console.WriteLine("indtast r for at vende et skridt tilbage. e for at afslutte. "); // afsluttende - skriv altid til sidst
            }
            if (InputSubject == "org")
            {
                Console.Clear();
                Console.WriteLine("indtast r for at vende et skridt tilbage. e for at afslutte. ");
                Console.WriteLine("-----------------------:");
                Console.WriteLine("ORGANISATIONER");
                Console.WriteLine("-----------------------:");
                Console.WriteLine();
                Console.WriteLine("ISO: International Organization for Standardization");
                Console.WriteLine();
                Console.WriteLine("TIA: Telecommunications Industry Association");
                Console.WriteLine();
                Console.WriteLine("EIA: Electronic Industries Association");
                Console.WriteLine();
                Console.WriteLine("ITU: International Telecommunication Union");
                Console.WriteLine();
                Console.WriteLine("ANSI: American National Standards Institute");
                Console.WriteLine();
                Console.WriteLine("IEEE: Institute of Electrical and Electronics Engineers");
                Console.WriteLine();
                Console.WriteLine("------- Nationale autoriteter indenfor telekommunikationsregulering -------");
                Console.WriteLine();
                Console.WriteLine("FCC: The Federal Communication Commission (USA)");
                Console.WriteLine();
                Console.WriteLine("ETSI: The European Telecommunications Standards Institute");
                Console.WriteLine();
                Console.WriteLine("---- Protokoller ----");
                Console.WriteLine();
                Console.WriteLine("IAB: Internet Architecture Board");
                Console.WriteLine();
                Console.WriteLine("ICANN: Internet Corporation for Assigned Names and Numbers");
                Console.WriteLine();
                Console.WriteLine("IETF: Internet Engineering Task Force");
                Console.WriteLine();
                Console.WriteLine("IANA - Internet Assigned Numbers Authority. På deres hjemmeside kan der findes en port registry liste for alle velkendte protokollers/programmers" +
                    "porte (se TRANSPORT afsnit for port number groups.");
                Console.WriteLine();
                Console.WriteLine("indtast r for at vende et skridt tilbage. e for at afslutte. "); // afsluttende - skriv altid til sidststring WaitForInput6 = Console.ReadLine();
                string WaitForInput7 = Console.ReadLine();
                if (WaitForInput7 == "r")
                {
                    return;
                }
                else if (WaitForInput7 == "e")
                {
                    Environment.Exit(0);
                }
            }
            if (InputSubject == "kon")
            {
                Console.Clear();
                Console.WriteLine("-----------------------:");
                Console.WriteLine("KONSOLLISTE:");
                Console.WriteLine("-----------------------:");
                Console.WriteLine();
                Console.WriteLine("Telnet: Remote access løsning. Indeholder ikke kryptering, og er derfor ikke udbredt længere, men erstattet af SSH");
                Console.WriteLine();
                Console.WriteLine("SSH: Secure Shell: Remote access løsning som Telnet, men indeholder kryptering, og er derfor væsentligt mere sikkert.");
                Console.WriteLine();
                Console.WriteLine("----Grundlæggende----:");
                Console.WriteLine();
                Console.WriteLine("user EXEC mode: Programmet vil starte i denne konfiguration. Dette er det laveste sikkerhedsniveau. " +
                "Der er adgang til følgende indstillinger: ");
                Console.WriteLine();
                Console.WriteLine("enable : fører dig et sikkerhedsniveau op, til Priviledged EXEC mode.");
                Console.WriteLine();
                Console.WriteLine("interface vlan 1: Vil føre brugeren videre til indstillinger for vlan port 1");
                Console.WriteLine();
                Console.WriteLine("show ip interface brief: Vil vise IP-adresser på netværket.");
                Console.WriteLine();
                Console.WriteLine("no shutdown: Sørger for at índstillinger i global configuration bliver gemt.");
                Console.WriteLine();
                Console.WriteLine("configure terminal: Sætter tilstand i global configuration sikkerhedstilstand (højeste sikkerhedsniveau)");
                Console.WriteLine();
                Console.WriteLine("do: gør det muligt at udstede commands fra lavere sikkerhedslag, når du er i global configuration mode.");
                Console.WriteLine();
                Console.WriteLine("erase startup-config: Sletter den gemte konfiguration på routeren");
                Console.WriteLine();
                Console.WriteLine("ip default-gateway: sætter routerens default gateway, ip skrives efter command");
                Console.WriteLine();
                Console.WriteLine("wr (eller) write: gemmer konfigurationen i priviledged EXEC mode.");
                Console.WriteLine();
                Console.WriteLine("startup-config: blev anvendt til at gemme indstillinger/ændringer. Anvender i stedet wr (write)");
                Console.WriteLine();
                Console.WriteLine("exit : Går et niveau længere ned i sikkerhedslagene (eks. Priviledged EXEC -> user EXEC)");
                Console.WriteLine();
                Console.WriteLine("end : Afslutter konsollen.");
                Console.WriteLine();
                Console.WriteLine("Router# : indikerer at du er i user exec mode"); // ><<<<<<<<<<<  RET / TJEK <<<<<<<<<<<<<< 
                Console.WriteLine();
                Console.WriteLine("line vty 0 4 : går ind i interface med en bestemt line. 0 og 4 erstattes med de udvalgte lines/porte i praksis.");
                Console.WriteLine();
                Console.WriteLine("(config-line) : indikrerer at du er i en bestemt line/port");
                Console.WriteLine();
                Console.WriteLine("password X : sætter password. X erstattes med udvalgte password i praksis.");
                Console.WriteLine();
                Console.WriteLine("show running-config : Viser routerens nuværende opsætning.");
                Console.WriteLine();
                Console.WriteLine("login : ");
                Console.WriteLine();
                Console.WriteLine("----Sikkerhedsindstillinger----:");
                Console.WriteLine();
                Console.WriteLine("exec-timeout 5 30 : opsætter antal forsøg på login og lockout tid på routerens interface.");
                Console.WriteLine();
                Console.WriteLine("transport input ssh : ");
                Console.WriteLine();
                Console.WriteLine("----Kommandoprompt (CMD)----:");
                Console.WriteLine("netstat: se TCP-forbindelser på et netværk. Anvendt til f.eks. at tjekke ukendte/fremmede TCP forbindelser der kan være sikkerhedstrusler.");
                Console.WriteLine();
                Console.WriteLine("ipconfig /displaydns : Víser DNS på forbundne netværk.");
                Console.WriteLine();
                Console.WriteLine("nslookup");
                Console.WriteLine("herunder kan -n command vise IP-adresser og port numbers.");
                Console.WriteLine("indtast r for at vende et skridt tilbage. e for at afslutte. "); // afsluttende - skriv altid til sidststring WaitForInput6 = Console.ReadLine();
                Console.ReadLine();
                string WaitForInput8 = Console.ReadLine();
                if (WaitForInput8 == "r")
                {
                    return;
                }
                else if (WaitForInput8 == "e")
                {
                    Environment.Exit(0);
                }

            }

        }
    }
}

/*
 ---- TEST AF OBJEKTER >>IKKE TIL FÆRDIGE AFLEVERING<< ----  
 Dictionary<string, string> categories = new Dictionary<string, string>();
        categories.Add("Organizations", "IEEE");
        categories.Add("Physical Layer (1)", "Connection Types");
        categories.Add("General/Overall", "The OSI model");

    Console.WriteLine("------------------");
    Console.WriteLine("");
    Console.WriteLine("");

// ANDEN METODE - CLASS //
class OSIModel
{
    public string TermName { get; set; }
    public string TermDisc { get; set; }
    public string TermCat { get; set; }
}

public void ShowDetails
{
    Console.WriteLine ("Begreb: );
    Console.WriteLine ("Navn : {0}, Beskrivelse:{1}, Kategori: {2}", TermName, TermDisc, TermCat); 
}

}





---- REGLER: ----
- writeline ved nyt koncept/begreb.
- /n (linebreak/new line) hvis under samme emne, men ny linie
- sat + ved linjer der fyldte for meget i mit program, i stedet for lange sætninger.
---->
hvorfor?: Visuelt mere overskueligt, da man nemmere har overblik over hvilke dele der er sit eget, og hvilke der hører under et overemne.

- Sat noter fra timen i sin egen tekst herunder 

---->
hvorfor?: I stedet for at starte forfra hver gang, kan jeg undervejs tilføje, således at de nye modulers begreber kommer naturligt.

- sortering: sat nogle emner fra et modul til f.eks. "generelle" eller "konsol".
---->
hvorfor?: Delvis for egen forståelse, men også især for overskueligheden. Nødvendigt i nogle at kategorisere dem bedre end hvad modulerne har (især 1-3, da de er intro).








--------------- MANGLER INDSÆT ---------------

under netværk eller packets?
                Console.WriteLine("Encapsulation: ");
                Console.WriteLine("Message formatting: ");




Fysiske Forbindelser til netværk:
RJ-45 (konsol-kabel)
USB EN (med adapter til serial port, enten indbygget eller fysisk adapter)

Konsol-commands:
user Exec mode
Priviledged Exec mode

grundlæggnede command structure:
prompt - command - space - keyword/argument
eks.
switch > show ip protocols
switch > ping 192.168.10.5

 


Unicast: send fra enhed til enhed
Multicast: send fra enhed til flere
Broadcast: send fra enhed til alle


adressing
reliablility
flow control
sequencing
error detection
application interface



OSI model: standarden for at forstå de forskellige lag af netværkskommunikation.
TCP/IP model: en gammel model som forklarer overordnet hvordan internetkommunikation foregår (application, transport, internet, Network access)

datastruktur over stadier:
data:
segment: 
packet: 
frame: 
bits: 

Encapsulation: samling af data i datastrukturen. 
de-encapsulation: udfoldning af data i datastrukturen.

encoding: måden hvorpå en datastrøm bliver konverteret fra bits til "kode". Se evt. Manchester encoding for et enkelt eksempel.

subnet mask: 


------ Fra timerne ------

MTU - message transmission unit
gateway of last resort - 
ARP - 
Duplex - 
bia - burned-in-address
default gateway - 
DAD - dublicate address detection
Oktet: 8-bit systemet til at beregne IP subnet
APIPA - automatic private IP addresssing.
RIR - regionale internet registre
VLSM - variable length subnet mask
DHCP - Dynamic Host Configuration Protocol. Tilegner automatisk en Subnet-IP-adresse fra /x (tal 1-30 IPv4) subnettet.
PDU - 

TCP-control bits:
URG - Urgent pointer field significant
ACK - Acknowledgment flag used in connection establishment and session termination
PSH - Push function
RST - Reset the connection when an error or timeout occurs
SYN - Synchronize sequence numbers used in connection establishment
FIN - No more data from sender and used in session termination


*/
