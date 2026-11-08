# Ändringshistorik

## [1.2.0] - Ej utgiven

### Tillagt

- Inspector, redigeringsåtgärder, installationsdialoger, standardposnamn och genererade VRChat-menyer kan visas på 30 språk.
- Språkvalet för Inspector och spelmenyn är gemensamt. Datorns språk används först, och det senaste valet återanvänds i andra projekt för samma OS-användare.
- README, ändringshistorik och offlineanvisningar kan öppnas på valt språk.
- Visningsnamn för 128 standardposer och funktionsbeskrivningar har tagits fram med befintlig terminologi.

### Kompatibilitet

- Befintliga avatarinställningar, egna namn, assetreferenser, parameteridentifierare och licensens lagringssätt bevaras.

## [1.1.0] - 2026-11-07

- 43 av 50 poser får automatisk lemanpassning med IK efter kroppsbyggnad; återstående 7 använder tidigare posejusteringar.
- Position och riktning kan justeras i Fotoläge med valfri synkronisering och visning av det egna huvudet.
- Golvhöjd flyttar hela kroppen 3m uppåt/nedåt, separat från Fothöjd.
- Tillagt andningsrörelse, avstängning av standardsvajning och minskad förvrängning från huvudrotation.
- Inspector visar aktiva funktioner och parameteranvändning. Sökning, massimport, omordning och enkel förhandsvisning i Scene stöds.
- Snabbare växling mellan stående, hukande och sittande i skrivbordsläge.
- Förbättrade förberäkningsvarningar efter ändringar, scrollbelastning i Inspector och långa stopp vid städning av genererade data.
- Stöd för Unisaki Posing System 3.1.0.
- Inga vändningsrörelser för medföljande poser ingår.

## [1.1.0-beta.2] - Öppen beta (2026-11-05)

- Automatisk lemanpassning (IK) konfigurerad för 43 av 50 poser. Återstående 7 använder tidigare posejusteringar.
- Stöd för gemensamma paketet 3.1.0-beta.2. Medföljande poser har inga vändningsrörelser.

## [1.1.0-beta.1] - Öppen beta (2026-11-04)

- Stöd för Unisaki Posing System 3.1.0-beta.1.
- Normal poseväxling i skrivbordsläge använder en utvärdering i vanliga byggen och förberäkning. VR och särskilda villkor använder tidigare väg.
- Förberäkningar från alpha.3 eller äldre identifieras som uppdateringskrävande.
- Synvinkeln bevaras vid ändrad golvhöjd i Fotoläge och återgår till senaste golvhöjd när Fotoläge avslutas.
- Inkluderar förbättringar genom alpha.3 för automatisk import, justering av importerade rörelser och hantering av genererade Controllers.

## [1.1.0-alpha.1] - Före offentlig utgivning

### Tillagt

- Tillagt Vänd dig och animationsinställningar per pose.
- Tillagt särskilda ikoner för Andning, Vänd dig, Golvhöjd, Fotoläge, Avstånd, Riktning och Avsluta foto.
- Tillagt Fotoläge för förflyttning framåt och rotation.
- Tillagt Fotoläge-synkronisering: endast lokalt 0 bit, synkroniserat 16 bit.
- Tillagt möjlighet att behålla det egna avatarhuvudet synligt i Fotoläge.
- Tillagt Golvhöjd som höjer hela kroppen inklusive huvudet.
- Tillagt andningsrörelse, styrka och på/av-meny i spelet.
- Tillagt avstängning av VRChats standardsvajning.
- Tillagt minskad förvrängning från huvudrotation.
- Tillagt skydd mot bakåtböjda knän och minsta böjvinkel.
- Tillagt på/av per funktion och ExpressionParameters-användning.
- Tillagt enkel förhandsvisning i Scene, possökning, massimport och målposition vid omordning.
- Tillagt ändringshistorik i Inspector.

### Ändrat

- Inspector indelad i Funktioner, Poser och Avatarinställningar.
- Omorganiserade andningsdetaljer, import av egna rörelser och förinställningar.
- Färre dubblerade animationer för fothöjd.
- Bekräftelsedialog för uppdatering av posebilder och samlade varningsinställningar under Kontrollera inställningar.
- Tilläggsmenyn för nya 8bit-versioner borttagen till förmån för funktionsval i vanliga Prefab; befintliga referenser bevaras.
- Stöd för Unisaki Posing System 3.1.0-alpha.1. Lägsta VRChat Avatars SDK-version ändrad till 3.10.4.

### Rättat

- Åtgärdat att posnamnsinmatning flyttades till en annan pose och att detaljer stängdes vid omordning.
- Åtgärdat överlappande förhandsvisningar, fel position och fel på vissa avatarer.
- Åtgärdat uppdatering av varningar/förberäkningsstatus efter inställningsändringar och vissa byggfel.

## [1.0.0] - 2026-09-06

- Slutlig utgivning.
- Tillagt avatarförinställningar (トネール, 狛乃, 士堂, 真央).

## [1.0.0-alpha.1] - 2026-09-06

- Utgivning.
