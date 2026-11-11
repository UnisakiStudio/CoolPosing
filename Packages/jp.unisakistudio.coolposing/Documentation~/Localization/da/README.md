# Cool Posing

Et positurlåsværktøj til VRChat med seje positurer, også med 3-punktssporing og på skrivebordet. Indeholder 50 positurer: 11 stående, 9 i hug, 14 siddende, 9 på ryggen og 7 på maven.

Denne README gælder v1.2.0 under udvikling. Endelig udgivelsesdato er ikke fastsat. Installeret version vises øverst i Inspector.

- [Produktside på BOOTH](https://yunisaki.booth.pm/items/8797334)
- [Ændringshistorik](CHANGELOG.md)

## Visningssprog og offlinedokumentation

Vælg visningssprog med ”Language / 言語” øverst i Inspector. Ét valg gælder både Inspector og den genererede VRChat-menu. Upload avataren igen for at ændre sproget i spillet.

Uden et valg bruges computerens sprog, eller engelsk hvis sproget ikke understøttes. Windows, macOS og Linux understøttes. Det seneste valg gemmes i EditorPrefs og bruges i andre projekter for samme OS-bruger på denne computer. Alle positurværktøjer og avatarer bruger samme sprog. En ændring i et hvilket som helst værktøjs Inspector opdaterer den fælles indstilling; sprogvalg for enkelte avatarer ignoreres. Valget synkroniseres ikke til andre computere. Licenslagringen ændres ikke. Sprogknappen vises kun ved den første installationsbekræftelse, hvis der ikke er gemt et sprog. Senere sprogændringer foretages i Inspector.

README, ændringshistorik og vejledning vælges fra den medfølgende [sprogliste](../index.html). Inspector-knapperne til vejledning og ændringshistorik følger også det valgte sprog. Originale brugsbetingelser og referenceoversættelser leveres fortsat separat.

## Vigtigste funktioner

- Automatisk lemjustering (IK): tilpasser lemmernes placering og retning til avatarens kropsbygning i 43 positurer.

- Fototilstand: flyt avataren op til 3m frem og justér retningen. Kun lokalt 0 bit; synlig position/retning for andre 16 bit.
- Hovedvisning under foto: forhindrer skjult eget hoved tæt på kameraet i Fototilstand.
- Gulvhøjde: flytter hele kroppen inklusive hovedet op til 3m op/ned, separat fra Fodhøjde med fast hovedposition.
- Vend dig: bruges med egne tilknyttede bevægelser. Medfølgende positurer har ingen vendeanimationer.
- Vejrtrækning: bevægelse i blandt andet brystkassen, med Ingen, Svag, Middel, Stærk, Hurtig eller Egen pr. kategori.
- Slå VRChats svajen i stilstand fra: dæmper standardsvajen og bevarer værktøjets vejrtrækning og andre egne bevægelser.
- Reducér forvrængning fra hovedrotation: dæmper forvrængning ved frigivet nakke og anden hovedretning end originalposituren.
- Funktionsvalg: tilføj ønskede spilmenuer og se ExpressionParameters-forbrug i Inspector.
- Søgning, massetilføjelse og rækkefølge: søg på tværs, importér flere klip og angiv målplacering.
- Let Scene-forhåndsvisning: se posituren direkte med Forhåndsvisning i listen.

- Menuikoner til nye funktioner: egne billeder til vejrtrækning, Vend dig, Gulvhøjde og Fototilstand m.fl., tilpasset produktets eksisterende ikoner.

### Konfigurér Vend dig

Slå ”Aktivér Vend dig” til i positurens Detaljer og angiv animation i ”Sidepositur til vending”. Normal MotionTime bliver utilgængelig. Aktivér også ”Funktioner > Menufunktioner > Vend dig”, upload og vælg posituren og Vend dig i VRChat med nakkelåsen frigivet.

Medfølgende positurer indeholder ingen vendeanimationer. Angiv passende animationer til de ønskede positurer.

## Understøttede avatarforudindstillinger og tilpasning

Tilpassede forudindstillinger til トネール, 狛乃, 士堂 og 真央 medfølger.

- [トネール](https://booth.pm/ja/items/5236104)
- [狛乃](https://booth.pm/ja/items/5260363)
- [士堂](https://booth.pm/ja/items/8086741)
- [真央](https://booth.pm/ja/items/6846646)

Andre avatarer kan også bruges. Tilpas efter kropsbygning og ændringer med Animationsjustering. Avataropsætning har også Forhindr bagudbøjning af knæ og detaljen Mindste knæbøjning (grader).

Automatisk lemjustering (IK) er aktiv som standard. 43 af 50 positurer bruger IK; resterende 7 bruger hidtidige individuelle justeringer.

## Installation

1. Hent filer fra produktsiden i butikken, hvor du købte varen.
2. Importér ”カッコいいポーズツール.unitypackage” i Unity og registrér licens og pakkekilde.
3. Tilføj Cool Posing og Modular Avatar til Unity-projektet i VCC eller ALCOM. Fælles Unisaki Posing System og NDMF installeres som afhængigheder.
4. Højreklik på avataren i Hierarchy og vælg ”Unisaki Studio > Tilføj Cool Posing”.
5. Vælg tilføjede ”カッコいいポーズ” i avataren og konfigurér funktioner og positurer i Inspector.
6. Upload avataren normalt.

Kræver Unity 2022.3, VRChat Avatars SDK 3.10.4 eller nyere, Modular Avatar 1.x fra 1.15.1 og NDMF 1.x fra 1.14.0. Opdatér nødvendige pakker sammen i VCC eller ALCOM.

## Opdatering fra tidligere versioner

Opdatér produktet sammen med Unisaki Posing System. Eksisterende værktøjsindstillinger bevares. Kontrollér funktioner og ExpressionParameters-forbrug i Inspector, og tryk ”Opdatér forberegning” før ny upload, hvis den bruges.

Fra v1.1.0 bruger nye tilføjelser det almindelige Prefab ”カッコいいポーズ”. Slå unødvendige funktioner fra for minimumsopsætning med kun positurvalg på 8 bit. Mange positurer kan kræve flere valgbits.

Ældre 8bit-Prefab bevares under ”Editor/Legacy” for eksisterende avatar- og forudindstillingsreferencer. Du behøver ikke slette eller erstatte eksisterende Prefab. 8bit vises ikke i Unitys menu for nye tilføjelser.

## Hvor indstillingerne findes

| Fane | Muligheder |
| --- | --- |
| Funktioner | Spilmenuer, praktiske funktioner, vejrtrækning, ikoner og ExpressionParameters-forbrug |
| Positurer | Valg, detaljer, søgning, massetilføjelse, rækkefølge, forhåndsvisning og animationsjustering |
| Avataropsætning | Avatarspecifik korrektion, knæ, oprindelige/egne bevægelser og forudindstillinger |

”Åbn indstillinger” viser detaljer under punktet. Vejrtrækning konfigureres via ”Funktioner > Praktiske funktioner > Animér vejrtrækning”.

”Brug oprindelige stående, hug- og mavepositurer” importerer avatarens oprindelige positurer automatisk. Egne bevægelser angives separat via importindstillinger for hver type, eksempelvis stående, hug (Crouching) og maveliggende (Prone).

Forudindstillinger findes nederst i Avataropsætning. ”Anvend denne forudindstilling” erstatter aktuelle indstillinger, så gem egne justeringer før skift.

### Forbrug pr. funktion

- Vejrtrækningsbevægelse bruger 0 bit. Kun ”Menufunktioner > Vejrtrækning” til stop/genstart i spillet bruger 1 bit til til/fra-synkronisering.
- Fototilstand bruger 0 bit kun lokalt. ”Praktiske funktioner > Synkronisér Fototilstand” bruger 16 bit. ”Hold hovedet synligt i Fototilstand” bruger 0 bit.
- Fodhøjde og Gulvhøjde bruger hver 8 bit. Gulvhøjde flytter hele kroppen op/ned fra midten og afslutter korrektion tæt på 50%.
- Vend dig alene bruger 10 bit og deler 1 bit med Reducér forvrængning fra hovedrotation, så begge tilsammen også bruger 10 bit.
- Spejlvend og Gestus fra bruger hver 1 bit.

Inspector-totalen omfatter avatarens positurværktøjer, ikke tøj og andre værktøjer. Delte indstillinger tælles ikke dobbelt ved flere positurværktøjer.

### Forhåndsvisning og redigering af positurer

”Forhåndsvisning” på hver positur viser den i Scene. Åbn ”Animationsjustering” for at gennemse, finjustere og gemme.

Let forhåndsvisning kører ikke MA- eller NDMF-build. Kontrollér tøj og gulvkorrektioner, som indarbejdes ved build, i det endelige resultat før upload.

Søg efter navne med forstørrelsesglasfanen til venstre. Vælg mål under ”Detaljer > Rækkefølge” eller brug op/ned. Tilføj flere animationer ved træk til feltet eller ”Importér klip valgt i Project”.

”Opdatér positurminiaturer” genererer billeder efter bekræftelse. ”Generér positurikoner” gør positurer lettere at kende i spilmenuen, men øger byggetid. Vælg ”Reducér ikonstørrelse” for mindre størrelse. Der genereres ikke positurikoner til Android.

## Grundlæggende spilbetjening

- Vælg positurer pr. kategori i Expressions. I VR skifter stående, hug, siddende og liggende efter hovedhøjde.
- Liggende skifter ryg/mave efter ansigtsretning. Med begge valgt kan hop også skifte; slå det fra under ”Funktioner → Praktiske funktioner → Skift liggende positurer ved at hoppe”. Kategorihøjder justeres med tærskler i indstillinger.
- På skrivebordet bruges C og Z. Hæv liggehøjdetærsklen i indstillinger, hvis Z ikke giver liggende.
- Gestus fra bruger positurens håndform i stedet for controllerfingre.
- Fodhøjde justerer fodsiden med fast hovedposition. Gulvhøjde flytter hele kroppen inklusive hovedet. De står i den rækkefølge i indstillinger.
- Afstand i Fototilstand flytter fremad og vender avataren mod dig. Drej med Retning og brug Lås fødder efter behov. Afslut foto nulstiller afstand/retning og frigiver fødder.
- Vejrtrækning virker med aktiv bevægelse. Styrke vælges i Unity, til/fra i spillet.

## Forberegning og advarsler

”Opdatér forberegning” genbruger genererede data til hurtigere avatarbuilds. Uden forberegning genereres nødvendige data også ved almindeligt build.

Efter ændringer vises opdateringsbehov under Kontrollér indstillinger øverst i Inspector og med Hierarchy-markeringer. Indstillinger for advarselsvisning findes i samme felt. Skjult visning løser ikke problemer eller opdaterer genererede data.

## Bemærkninger om brug

- Positurlåsning med fuldkropssporing understøttes ikke.
- Kropsbygning, tøj og ændringer kan kræve ekstra justering.
- Særlige Base-lag og andre positurværktøjer kan integrere uventet. Kontrollér ”Avataropsætning > Integrér sporingslåsninger med andre værktøjer” ved låseproblemer.
- Fototilstand-bevægelse/rotation og Gulvhøjde korrigerer værktøjspositurer og standard-/egne bevægelser uden valgt positur. Kontrollér endeligt synspunkt og erstattede bevægelser i VRChat-klienten.
- Slå VRChats svajen i stilstand fra påvirker standardanimationen, ikke alle andre årsager til svajen.

## Vejledning og support

Åbn vejledning, kontakt og ændringshistorik via ”Hjælp / Ændringer” øverst i Inspector. Fælles funktioner beskrives også under ”Packages > Unisaki Posing System > README” i Unitys Project.

- [Officiel vejledning](https://docs.unisakistudio.jp/coolposing/manual/)
- [Kontakt](https://help.unisakistudio.jp/)

Ved fejlrapportering: oplys produkt- og Unisaki Posing System-versioner, Unity/VRChat SDK/Modular Avatar/NDMF-versioner, avatar, trin til genskabelse og Console-fejl.

## Brugsbetingelser

Produktet indeholder VN3-brugsbetingelserne ”ゆにさきスタジオ販売・配布データ利用規約（日本語版）Ver1.0.0.pdf”, fælles for Unisaki Studios solgte/distribuerede data. Læs dem før brug.

Kildekode og ressourcer er ikke open source. Gyldige købere får brugsret inden for medfølgende brugsbetingelser.
