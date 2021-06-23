# SvanteASPNET1

ASP.NET applikationer innehåller alltid en startup klass. Start up körs när applikationen startas. Genom .UseStartup(); i program.cs använder vi startup klassen och dess kod.

I startup hittar vi två public methods.

ConfigureServices()
ConfigureServices kallas på i program.cs genom .Build(). I configureservices() kan man ange sina services som sedan kan användas i ens applikation/program. Detta kan t.ex vara Identity paketet för att hantera authurization osv.

Configure()
När vi kör .Run() i program.cs så körs configure() ifrån startup.cs. Här kan vi konfigurera vår pipline genom att använda IApplicationBuilder. I pipelinen har vi något som kallas för middleware komponenter, dessa kan jämföras med en trappa, vi börjar uppifrån när ett http request kommer in från klienten (webHost). Detta pågår upp och ner för trappan och beroende på requesten aktiveras olika delar så att prestandaden hålls optimal. Man får passa sig så att man inte lägger till onödiga trappsteg alltså middleware komponenter.

wwwroot

Här hittar vi javascript, html, images och css-kod som följer med varje nytt projekt per default. Här behöver man sällan pilla.

Program.cs
Här börjar programmet. Här skapar vi en host (webhost, .build() för applikationen som beskrivs ovan.
Därefter kallas .Run() när vi kallar på .run() så fortsätter mainprocessen inuti WebHost.

CreatDefaultBuilder skapar en instans av webhostbuilder och skapar kestrel. Kestrel är webservern som kör asp.net core project templates, här körs även appsettings.json filer genom att configureappconfiguration() kallas.

Razor
Razorkod blandar html och c# språk. En razor page har en .cshtml fil och en .cshtml.cs fil. Man använder sig mycket utav @ för att koppla ihop c# koden med html märkspråket.

Content Page
Sköter den visuella biten, UIn. Dessa slutar på .cshtml.

Page Model
Här har vi de sidor som slutar på .cshtml.cs, här skriver vi vår c# kod, det här är backenden här sköts logik, här finns publika metoder som OnGet och OnPost dessa kallas för page handlers.

MVC

Model

Här beskrivs vilka tables som skall finnas i databasen.

View

Är en fil som används för att visa data, genom att använda sig utav objekt från model klassen/klasserna.

Controller

Hanterar inkommande url requests. Den innehåller metoder som kallas för action metoder. Innebär detta att John McClane eller Rambo kommer storma in genom skorstenen och skjuta sönder din dator kanske du undrar, nej.
Dessa hämtar nödvändig model data för att svara på browser requests. Alla controllers klassnamn skall sluta med controller och finnas i controller mappen.
