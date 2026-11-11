# Cool Posing

Positurlåsverktøy for VRChat med kule positurer, også med trepunktssporing og på skrivebordet. Inneholder 50 positurer: 11 stående, 9 i huk, 14 sittende, 9 i ryggleie og 7 i mageleie.

Denne README gjelder v1.2.0 under utvikling. Endelig utgivelsesdato er ikke fastsatt. Installert versjon vises øverst i Inspector.

- [Produktside på BOOTH](https://yunisaki.booth.pm/items/8797334)
- [Endringslogg](CHANGELOG.md)

## Visningsspråk og dokumentasjon uten nett

Velg språk med «Language / 言語» øverst i Inspector. Ett valg styrer både Inspector og den genererte VRChat-menyen. Last opp avataren på nytt for å endre språket i spillet.

Uten valg brukes datamaskinens språk, eller engelsk hvis språket ikke støttes. Windows, macOS og Linux støttes. Siste valg lagres i EditorPrefs og brukes i andre prosjekter for samme OS-bruker på denne maskinen. Alle positurverktøy og avatarer bruker samme språk. En endring i Inspector for et hvilket som helst verktøy oppdaterer den felles innstillingen; språkvalg for enkeltavatarer ignoreres. Det synkroniseres ikke til andre maskiner. Lisenslagringen endres ikke. Språkknappen vises bare ved den første installasjonsbekreftelsen hvis ingen språk er lagret. Senere språkendringer gjøres i Inspector.

Velg README, endringslogg og brukerveiledning fra medfølgende [språkliste](../index.html). Inspector-knappene for brukerveiledning og endringer følger også språket. Originale bruksvilkår og referanseoversettelser leveres separat som før.

## Hovedfunksjoner

- Automatisk justering av armer og ben (IK): tilpasser plassering og retning etter kroppsbygning i 43 positurer.

- Fotomodus: flytt avataren opptil 3m frem og juster retningen. Bare lokalt 0 bit, synlig posisjon/retning for andre 16 bit.
- Hodevisning ved foto: hindrer at eget hode nær kameraet skjules i Fotomodus.
- Gulvhøyde: flytter hele kroppen inkludert hodet opptil 3m opp/ned, atskilt fra Fothøyde med fast hodeposisjon.
- Snu deg: brukes med passende bevegelser du angir selv. Medfølgende positurer har ingen animasjoner for snuing.
- Pust: bevegelse i blant annet brystkassen med Ingen, Svak, Middels, Sterk, Rask eller Egendefinert per kategori.
- Deaktiver VRChats hvilebevegelse: demper standardbevegelsen og beholder verktøyets pust og andre egne bevegelser.
- Reduser positurforvrengning fra hoderotasjon: demper forvrengning ved frigitt nakke når hodet peker annerledes enn originalposituren.
- Funksjonsvalg: legg til ønskede spillmenyer og se ExpressionParameters-forbruk i Inspector.
- Søk, massetillegg og sortering: søk på tvers, importer flere klipp og velg målplassering.
- Enkel Scene-forhåndsvisning: se posituren direkte med Forhåndsvisning i listen.

- Menyikoner for nye funksjoner: egne bilder for pust, Snu deg, Gulvhøyde og Fotomodus med mer, tilpasset produktets eksisterende ikoner.

### Sett opp Snu deg

Slå på «Aktiver Snu deg» i positurens Detaljer og angi animasjon i «Sidepositur for Snu deg». Vanlig MotionTime blir utilgjengelig. Aktiver også «Funksjoner > Menyfunksjoner > Snu deg», last opp og velg posituren og Snu deg i VRChat med frigitt nakkelås.

Medfølgende positurer inneholder ingen animasjoner for snuing. Angi passende animasjoner for positurene du ønsker å bruke.

## Støttede avatarforhåndsinnstillinger og tilpasning

Tilpassede forhåndsinnstillinger for トネール, 狛乃, 士堂 og 真央 følger med.

- [トネール](https://booth.pm/ja/items/5236104)
- [狛乃](https://booth.pm/ja/items/5260363)
- [士堂](https://booth.pm/ja/items/8086741)
- [真央](https://booth.pm/ja/items/6846646)

Andre avatarer kan også brukes. Tilpass etter kroppsbygning og endringer med Animasjonsjustering. Avataroppsett har også Hindre bakoverbøyning av knær og detaljen Minste knebøyning (grader).

Automatisk lemjustering (IK) er på som standard. 43 av 50 positurer bruker IK; de resterende 7 bruker tidligere individuelle justeringer.

## Installasjon

1. Last ned filene fra produktsiden i butikken der du kjøpte.
2. Importer «カッコいいポーズツール.unitypackage» i Unity og registrer lisens og pakkekilde.
3. Legg til Cool Posing og Modular Avatar i prosjektet med VCC eller ALCOM. Felles Unisaki Posing System og NDMF installeres som avhengigheter.
4. Høyreklikk avataren i Hierarchy og velg «Unisaki Studio > Legg til Cool Posing».
5. Velg tilføyd «カッコいいポーズ» i avataren og angi funksjoner/positurer i Inspector.
6. Last opp normalt.

Krever Unity 2022.3, VRChat Avatars SDK 3.10.4 eller nyere, Modular Avatar 1.x fra 1.15.1 og NDMF 1.x fra 1.14.0. Oppdater nødvendige pakker sammen i VCC eller ALCOM.

## Oppdatering fra eldre versjoner

Oppdater produktet og Unisaki Posing System sammen. Eksisterende verktøyinnstillinger beholdes. Kontroller funksjoner og ExpressionParameters-forbruk i Inspector, og trykk «Oppdater forhåndsbygget» før ny opplasting hvis det brukes.

Fra v1.1.0 bruker nye tillegg vanlig Prefab «カッコいいポーズ». Slå av unødige funksjoner for minste oppsett med bare positurvalg på 8 bit. Mange positurer kan kreve flere valgbiter.

Eldre 8bit-Prefab beholdes under «Editor/Legacy» for eksisterende avatar- og forhåndsinnstillingsreferanser. Eksisterende Prefab trenger ikke slettes eller erstattes. 8bit vises ikke i Unitys meny for nye tillegg.

## Hvor innstillingene finnes

| Fane | Muligheter |
| --- | --- |
| Funksjoner | Spillmenyer, praktiske funksjoner, pust, ikoner og ExpressionParameters-forbruk |
| Positurer | Valg, detaljer, søk, massetillegg, sortering, forhåndsvisning og animasjonsjustering |
| Avataroppsett | Avatarkorrigering, knær, originale/egne bevegelser og forhåndsinnstillinger |

«Åpne innstillinger» viser detaljer under valget. Pust konfigureres under «Funksjoner > Praktiske funksjoner > Animer pusten».

«Bruk opprinnelige stå-, huk- og mageleiepositurer» importerer originalpositurer automatisk. Egne bevegelser angis separat i importinnstillinger per type, eksempelvis stående, huk (Crouching) og mageleie (Prone).

Forhåndsinnstillinger finnes nederst i Avataroppsett. «Bruk denne forhåndsinnstillingen» erstatter nåværende oppsett, så lagre egne justeringer før bytte.

### Forbruk per funksjon

- Pustebevegelse bruker 0 bit. Bare «Menyfunksjoner > Pust» for stopp/start i spillet bruker 1 bit til på/av-synkronisering.
- Fotomodus bruker 0 bit bare lokalt. «Praktiske funksjoner > Synkroniser Fotomodus» bruker 16 bit. «Behold hodet synlig i Fotomodus» bruker 0 bit.
- Fothøyde og Gulvhøyde bruker hver 8 bit. Gulvhøyde flytter hele kroppen opp/ned fra midten, og korrigeringen slutter nær 50%.
- Snu deg bruker 10 bit alene og deler 1 bit med Reduser positurforvrengning fra hoderotasjon, så begge bruker 10 bit totalt.
- Speilvend og Gester av bruker hver 1 bit.

Inspector-summen omfatter avatarens positurverktøy, ikke klær eller andre systemer. Felles innstillinger telles ikke dobbelt ved flere verktøy.

### Forhåndsvisning og positurredigering

Forhåndsvisning på hver positur viser den i Scene. Åpne Animasjonsjustering for å gjennomgå, finjustere og lagre.

Enkel forhåndsvisning kjører ikke MA- eller NDMF-bygg. Kontroller også klær og gulvkorrigering som innarbeides ved bygg i sluttresultatet før opplasting.

Søk etter navn med forstørrelsesglassfanen til venstre. Velg mål under «Detaljer > Rekkefølge» eller bruk opp/ned. Legg til flere animasjoner ved å dra til feltet eller bruke «Importer klipp valgt i Project».

«Oppdater positurminiatyrer» genererer bilder etter bekreftelse. «Generer positurikoner» gjør positurer lettere å kjenne i spillmenyen, men øker byggetid. Velg «Reduser ikonstørrelsen» for mindre størrelse. Android får ingen genererte positurikoner.

## Grunnleggende spillkontroller

- Velg positurer per kategori i Expressions. I VR byttes stående, huk, sittende og liggende etter hodehøyde.
- Liggende byttes rygg/mage etter ansiktsretning. Med begge valgt kan hopp også bytte; slå av under «Funksjoner → Praktiske funksjoner → Bytt liggende positur ved å hoppe». Kategoriers høydeterskler justeres i innstillinger.
- På skrivebordet brukes C og Z. Øk liggehøydeterskelen hvis Z ikke gir liggende.
- Gester av bruker positurens håndform i stedet for kontrollerstyrte fingre.
- Fothøyde justerer fotsiden med fast hodeposisjon. Gulvhøyde flytter hele kroppen inkludert hodet. De står i denne rekkefølgen i innstillinger.
- Avstand i Fotomodus flytter frem og vender avataren mot deg. Roter med Retning og bruk Lås føtter ved behov. Avslutt foto nullstiller avstand/retning og frigir føttene.
- Pust virker med aktiv pustebevegelse. Styrke velges i Unity, på/av i spillet.

## Forhåndsbygg og advarsler

«Oppdater forhåndsbygget» gjenbruker genererte data for raskere avatarbygg. Vanlig bygg genererer også nødvendige data uten forhåndsbygg.

Endringer gir oppdateringsbehov under Kontroller innstillinger øverst i Inspector og med Hierarchy-merker. Innstillinger for advarselsvisning finnes i samme felt. Skjulte advarsler løser ikke problemer eller oppdaterer genererte data.

## Merknader om bruk

- Positurlås med helkroppssporing støttes ikke.
- Kroppsbygning, klær og avatarendringer kan kreve ekstra justering.
- Spesielle Base-lag og andre positurverktøy kan samordnes uventet. Kontroller «Avataroppsett > Samordne sporingslåser med andre verktøy» ved låseproblemer.
- Fotomodus-bevegelse/rotasjon og Gulvhøyde korrigerer verktøypositurer og standard-/egne bevegelser uten valgt positur. Kontroller endelig synspunkt og erstattede bevegelser i VRChat-klienten.
- Deaktiver VRChats hvilebevegelse påvirker standardanimasjonen, ikke alle andre årsaker til svai.

## Veiledning og støtte

«Hjelp / Endringer» øverst i Inspector åpner veiledning, kontakt og endringslogg. Fellesfunksjoner beskrives også under «Packages > Unisaki Posing System > README» i Unitys Project.

- [Offisiell veiledning](https://docs.unisakistudio.jp/coolposing/manual/)
- [Kontakt](https://help.unisakistudio.jp/)

Ved feilrapportering: oppgi produkt-/Unisaki Posing System-versjoner, Unity/VRChat SDK/Modular Avatar/NDMF-versjoner, avatar, trinn for gjenskaping og Console-feil.

## Bruksvilkår

Produktet inkluderer VN3-vilkårene «ゆにさきスタジオ販売・配布データ利用規約（日本語版）Ver1.0.0.pdf», felles for data solgt/distribuert av Unisaki Studio. Les dem før bruk.

Kildekode og ressurser er ikke åpen kildekode. Gyldige kjøpere får bruksrett innenfor medfølgende vilkår.
