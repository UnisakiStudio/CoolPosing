# Cool Posing

Ett poslåsverktyg för VRChat som ger coola poser även med 3-punktsspårning och i skrivbordsläge. Innehåller totalt 50 poser: 11 stående, 9 hukande, 14 sittande, 9 liggande på rygg och 7 liggande på mage.

Denna README gäller v1.2.0 under utveckling. Datum för slutlig utgivning är inte bestämt. Installerad version visas högst upp i Inspector.

- [Produktsida på BOOTH](https://yunisaki.booth.pm/items/8797334)
- [Ändringshistorik](CHANGELOG.md)

## Visningsspråk och offlinedokumentation

Välj språk under Language / 言語 överst i Inspector. Samma val styr Inspector och genererade VRChat-menyer. Ladda upp avataren igen för att ändra språk i spelet.

Utan uttryckligt val används datorns språk, annars engelska om språket saknas. Windows, macOS och Linux stöds. Senaste val sparas i EditorPrefs för andra projekt med samma systemanvändare på denna dator. Alla posverktyg och avatarer använder samma språk. En ändring i något verktygs Inspector uppdaterar den gemensamma inställningen; språkval för enskilda avatarer ignoreras. Ingen synkronisering till andra datorer. Licenslagring ändras inte. Språkknappen visas bara vid den första installationsbekräftelsen om inget språk har sparats. Senare språkändringar görs i Inspector.

Välj språk för README, historik och handbok i medföljande [språklista](../index.html). Inspectors handbok och ändringar följer också valet. Originalvillkor och referensöversättningar finns fortsatt separat.

## Huvudfunktioner

- Automatisk justering av lemmar (IK): anpassar lemmarnas placering och riktning till avatarens kroppsbyggnad i 43 poser.

- Fotoläge: flytta avataren upp till 3m framåt och justera riktningen. Endast lokalt använder 0 bit; att visa position och riktning för andra använder 16 bit.
- Visa huvudet under fotografering: förhindrar att ditt eget avatarhuvud nära kameran döljs under Fotoläge.
- Golvhöjd: flyttar hela kroppen inklusive huvudet upp till 3m uppåt/nedåt, separat från Fothöjd som behåller huvudpositionen och flyttar fötternas sida.
- Vänd dig: kan användas för poser där du själv anger lämpliga rörelser. Medföljande poser innehåller inga vändningsrörelser.
- Andning: ger bland annat bröstkorgen andningsrörelser. Välj Ingen, Svag, Medel, Stark, Snabb eller Egen per kategori.
- Stäng av VRChats stillastående svajning: minskar standardsvajningen och behåller verktygets andning och andra egna rörelser.
- Minska förvrängning från huvudrotation: minskar förvrängning vid upplåst nacke när huvudriktningen skiljer sig från ursprungsposens.
- Funktionsval: lägg endast till önskade spelmenyer och se ExpressionParameters-användning i Inspector.
- Sökning, massimport och omordning: sök över kategorier, importera flera klipp och ange målordning.
- Enkel förhandsvisning i Scene: se posen direkt med Förhandsvisning i poslistan.

- Menyikoner för nya funktioner: särskilda bilder för bland annat Andning, Vänd dig, Golvhöjd och Fotoläge, anpassade till produktens befintliga ikoner.

### Ställ in Vänd dig

Aktivera ”Aktivera Vänd dig” i posens ”Detaljer” och ange en animation i ”Sidopose för vändning”. Vanliga MotionTime-inställningar blir otillgängliga. Aktivera även ”Funktioner > Menyfunktioner > Vänd dig”, ladda upp och välj den stödda posen och Vänd dig i VRChat. Använd med upplåst nacke.

De medföljande poserna innehåller inga vändningsrörelser. Ange lämpliga animationer för de poser du vill använda.

## Stödda avatarförinställningar och justering

Justerade förinställningar för トネール, 狛乃, 士堂 och 真央 medföljer.

- [トネール](https://booth.pm/ja/items/5236104)
- [狛乃](https://booth.pm/ja/items/5260363)
- [士堂](https://booth.pm/ja/items/8086741)
- [真央](https://booth.pm/ja/items/6846646)

Andra avatarer kan också användas. Anpassa poserna efter kroppsbyggnad och ändringar med ”Animationsjustering”. Under ”Avatarinställningar” finns även ”Förhindra bakåtböjda knän” och detaljen ”Minsta knäböjning (grader)”.

Automatisk lemanpassning (IK) är aktiverad som standard. 43 av de 50 poserna använder IK och de återstående 7 använder tidigare posejusteringar.

## Installation

1. Hämta filerna från produktsidan i butiken där du köpte verktyget.
2. Importera medföljande ”カッコいいポーズツール.unitypackage” i Unity och registrera licensen och paketkällan.
3. Lägg till Cool Posing och Modular Avatar i Unity-projektet med VCC eller ALCOM. Gemensamma Unisaki Posing System och NDMF installeras också som beroenden.
4. Högerklicka på avataren i Hierarchy och välj ”Unisaki Studio > Lägg till Cool Posing”.
5. Välj tillagda ”カッコいいポーズ” i avataren och ange önskade funktioner och poser i Inspector.
6. Ladda upp avataren som vanligt.

Kräver Unity 2022.3, VRChat Avatars SDK 3.10.4 eller senare, Modular Avatar 1.x från 1.15.1 och NDMF 1.x från 1.14.0. Uppdatera nödvändiga paket tillsammans i VCC eller ALCOM.

## Uppdatering från tidigare versioner

Uppdatera produkten och Unisaki Posing System tillsammans. Inställningar i redan placerade verktyg bevaras. Kontrollera aktiva funktioner och ExpressionParameters-användning i Inspector. Om du använde förberäkning trycker du på ”Uppdatera förberäkning” före ny uppladdning.

Sedan v1.1.0 använder nya tillägg vanliga Prefab ”カッコいいポーズ”. Stäng av onödiga alternativ under Funktioner för en minsta konfiguration med enbart poseval på 8 bit. Många poser kan kräva ytterligare valbitar.

Äldre 8bit-Prefab finns kvar under ”Editor/Legacy” för befintliga avatar- och förinställningsreferenser. Befintliga Prefab behöver inte raderas eller ersättas. 8bit-versionen visas inte i Unitys meny för nya tillägg.

## Var inställningarna finns

| Flik | Funktioner |
| --- | --- |
| Funktioner | Spelmenyer, praktiska funktioner, andningsinställningar, ikoner och ExpressionParameters-användning |
| Poser | Poseval, detaljer, sökning, massimport, ordning, förhandsvisning och animationsjustering |
| Avatarinställningar | Avatarspecifik korrigering, knäkorrigering, import av ursprungliga/egna rörelser och byte av förinställning |

”Öppna inställningar” öppnar detaljer under det aktuella alternativet. Andning ställs in via ”Funktioner > Praktiska funktioner > Animera andning”.

”Använd ursprungliga stående, hukande och magposer” importerar avatarens ursprungliga poser automatiskt. Egna rörelser anges separat via importinställningarna för varje typ, såsom stående, hukande (Crouching) och magläge (Prone).

Förinställningarna finns längst ned i ”Avatarinställningar”. ”Tillämpa den här förinställningen” ersätter aktuella poseinställningar, så spara egna justeringar innan du byter.

### Användning per funktion

- Andningsrörelse använder 0 bit. Endast ”Menyfunktioner > Andning”, som pausar/återupptar i spelet, använder 1 bit för på/av-synkronisering.
- Fotoläge använder 0 bit om det bara syns lokalt. ”Praktiska funktioner > Synkronisera Fotoläge” använder 16 bit. ”Håll huvudet synligt i Fotoläge” använder 0 bit.
- Fothöjd och Golvhöjd använder 8 bit vardera. Golvhöjd flyttar hela kroppen uppåt/nedåt från mitten, och korrigeringen avslutas nära 50%.
- Vänd dig använder 10 bit ensamt. Det delar 1 bit med ”Minska förvrängning från huvudrotation”, så båda tillsammans använder också 10 bit.
- Spegla och Gester av använder 1 bit vardera.

Summan i Inspector omfattar de installerade poseverktygen på avataren, inte kläder eller andra verktyg. Gemensamma inställningar dubbelräknas inte när flera poseverktyg används.

### Förhandsvisning och posredigering

”Förhandsvisning” på varje pose under ”Poser” visar posen i Scene. För finjustering öppnar du ”Animationsjustering”, granskar posen och sparar ändringarna.

Enkel förhandsvisning kör inte MA:s eller NDMF:s byggprocess. Kontrollera även kläder och golvkorrigeringar som läggs till vid bygge i byggresultatet före uppladdning.

Sök posnamn med förstoringsglasfliken till vänster. Välj målposition under ”Detaljer > Ordning” eller använd uppåt-/nedåtknappar. Lägg till flera animationer genom att dra dem till tilläggsfältet eller använda ”Importera klipp valda i Project”.

”Uppdatera poseminiatyrer” genererar bilder efter en bekräftelsedialog. ”Generera poseikoner” gör poser lättare att känna igen i spelmenyn men förlänger byggtiden. Välj ”Minska ikonstorlek” för att minska storleken. Poseikoner genereras inte för Android.

## Grundkontroller i spelet

- Välj poser per kategori i Expressions-menyn. I VR växlar stående, hukande, sittande och liggande efter huvudhöjd.
- I liggande läge växlar rygg/mage efter ansiktsriktning. Med båda valda kan du också hoppa för att växla, vilket kan stängas av under ”Funktioner → Praktiska funktioner → Växla liggande poser genom att hoppa”. Kategoriernas höjdgränser justeras i inställningsmenyn.
- På skrivbordet växlar C och Z pose. Höj tröskeln för liggande i inställningsmenyn om Z inte ger liggande läge.
- Gester av använder posens handform i stället för kontrollerstyrda fingrar.
- Fothöjd justerar fötternas sida med bibehållen huvudposition. Golvhöjd flyttar hela kroppen inklusive huvudet uppåt/nedåt. De står i denna ordning i inställningsmenyn.
- När Avstånd i Fotoläge flyttar avataren framåt vänder den sig mot dig. Rotera med Riktning och aktivera Lås fötter vid behov. Avsluta foto återställer avstånd/riktning och låser upp fötterna.
- Andning är tillgängligt när andningsrörelsen är aktiverad. Styrkan anges i Unity och på/av växlas i spelet.

## Förberäkning och varningar

”Uppdatera förberäkning” återanvänder genererade data för snabbare avatarbyggen. Även utan förberäkning genereras nödvändiga data under ett vanligt bygge.

Efter ändringar visas uppdateringsbehov under ”Kontrollera inställningar” högst upp i Inspector och med markeringar i Hierarchy. ”Inställningar för varningsvisning” finns i samma ruta. Att dölja varningar löser inte inställningsproblem och uppdaterar inte genererade data.

## Att tänka på vid användning

- Poslåsning med helkroppsspårning stöds inte.
- Kroppsbyggnad, kläder och avatarändringar kan kräva extra justering.
- Särskilda Base-lager eller andra poseverktyg kan ge oväntad integration. Kontrollera ”Avatarinställningar > Integrera spårningslås med andra verktyg” om låsningen inte fungerar.
- Förflyttning/rotation i Fotoläge och Golvhöjd korrigerar verktygsposer samt vanliga/egna rörelser när ingen pose är vald. Kontrollera slutlig synvinkel och ersatta rörelser i VRChat-klienten.
- Stäng av VRChats stillastående svajning påverkar standardanimationen; funktionen stoppar inte all svajning från andra orsaker.

## Anvisningar och support

Via ”Hjälp / Ändringar” högst upp i Inspector öppnar du anvisningar, support och ändringshistorik. Detaljer om gemensamma funktioner finns även under ”Packages > Unisaki Posing System > README” i Unitys Project.

- [Officiell handbok](https://docs.unisakistudio.jp/coolposing/manual/)
- [Kontakta oss](https://help.unisakistudio.jp/)

Vid felrapportering: ange produktens och Unisaki Posing Systems versioner, versionerna av Unity, VRChat SDK, Modular Avatar och NDMF, använd avatar, steg för att återskapa felet och Console-fel.

## Användarvillkor

Produkten innehåller VN3-användarvillkoren ”ゆにさきスタジオ販売・配布データ利用規約（日本語版）Ver1.0.0.pdf”, som gäller gemensamt för data som Unisaki Studio säljer eller distribuerar. Läs dem före användning.

Källkoden och resurserna i detta repository är inte öppen källkod. Giltiga köpare får använda dem inom de medföljande användarvillkoren.
