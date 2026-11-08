# Ændringshistorik

## [1.2.0] - Ikke udgivet

### Tilføjet

- Inspector, redigeringshandlinger, installationsdialoger, standardpositurnavne og genererede VRChat-menuer kan vises på 30 sprog.
- Inspector og spilmenu bruger fælles sprogvalg. Først bruges computerens sprog, og seneste valg genbruges i andre projekter for samme OS-bruger.
- README, ændringshistorik og offlinevejledning kan åbnes på valgt sprog.
- Visningsnavne for 128 standardpositurer og funktionsbeskrivelser følger eksisterende terminologi.

### Kompatibilitet

- Eksisterende avatarindstillinger, egne navne, assetreferencer, parameteridentifikatorer og licenslagring bevares.

## [1.1.0] - 2026-11-07

- 43 af 50 positurer tilpasser lemmer automatisk med IK efter kropsbygning; resterende 7 bruger hidtidige justeringer.
- Fototilstand justerer position/retning med valgfri synkronisering og eget hoved synligt.
- Gulvhøjde flytter hele kroppen 3m op/ned, separat fra Fodhøjde.
- Tilføjet vejrtrækning, stop af standardsvajen og reduceret forvrængning fra hovedrotation.
- Inspector viser funktioner/parameterforbrug. Søgning, massetilføjelse, omarrangering og Scene-forhåndsvisning understøttes.
- Hurtigere stående/hug/siddende-skift på skrivebordet.
- Forbedrede forberegningsadvarsler, Inspector-rulning og lange oprydningsstop.
- Understøtter Unisaki Posing System 3.1.0.
- Vendeanimationer til medfølgende positurer er ikke inkluderet.

## [1.1.0-beta.2] - Åben beta (2026-11-05)

- Automatisk lemjustering (IK) til 43 af 50 positurer; resterende 7 bruger hidtidige justeringer.
- Understøtter fællespakken 3.1.0-beta.2. Ingen vendeanimationer følger med positurerne.

## [1.1.0-beta.1] - Åben beta (2026-11-04)

- Understøtter Unisaki Posing System 3.1.0-beta.1.
- Normalt positurskift på skrivebordet bruger én evaluering ved almindelige builds og forberegning; VR og særlige forhold beholder tidligere vej.
- Forberegninger fra alpha.3 eller før skal opdateres.
- Synspunkt bevares ved gulvhøjdeændring i Fototilstand, og seneste gulvhøjde gendannes ved afslutning.
- Medtager forbedringer gennem alpha.3 af automatisk import, justering af importerede bevægelser og genererede Controllers.

## [1.1.0-alpha.1] - Før offentlig udgivelse

### Tilføjet

- Tilføjet Vend dig og animation pr. positur.
- Tilføjet ikoner til vejrtrækning, Vend dig, Gulvhøjde, Fototilstand, Afstand, Retning og Afslut foto.
- Tilføjet Fototilstand med fremadflytning og rotation.
- Fototilstand-synkronisering: kun lokalt 0 bit, synkroniseret 16 bit.
- Tilføjet eget hoved synligt i Fototilstand.
- Tilføjet Gulvhøjde til at hæve hele kroppen inklusive hovedet.
- Tilføjet vejrtrækningsbevægelse, styrke og til/fra-menu.
- Tilføjet stop af VRChats standardsvajen.
- Tilføjet reduceret forvrængning fra hovedrotation.
- Tilføjet beskyttelse mod bagudbøjede knæ og mindste bøjevinkel.
- Tilføjet til/fra pr. funktion og ExpressionParameters-forbrug.
- Tilføjet Scene-forhåndsvisning, søgning, massetilføjelse og målplacering i rækkefølge.
- Tilføjet historik i Inspector.

### Ændret

- Inspector opdelt i Funktioner, Positurer og Avataropsætning.
- Vejrtrækningsdetaljer, import af egne bevægelser og forudindstillinger omorganiseret.
- Færre dublerede Fodhøjde-animationer.
- Bekræftelse ved positurbilledopdatering og advarselsvalg samlet under Kontrollér indstillinger.
- Ny 8bit-tilføjelsesmenu afskaffet til fordel for almindeligt Prefab med funktionsvalg; eksisterende referencer bevares.
- Understøtter Unisaki Posing System 3.1.0-alpha.1. Mindste VRChat Avatars SDK-version er 3.10.4.

### Rettet

- Rettet navneinput, som flyttedes til anden positur, og detaljer, som lukkedes ved omarrangering.
- Rettet overlappende forhåndsvisninger, forkert placering og fejl på visse avatarer.
- Rettet opdatering af advarsler/forberegningsstatus efter ændringer samt visse buildfejl.

## [1.0.0] - 2026-09-06

- Endelig udgivelse.
- Tilføjet avatarforudindstillinger (トネール, 狛乃, 士堂, 真央).

## [1.0.0-alpha.1] - 2026-09-06

- Udgivelse.
