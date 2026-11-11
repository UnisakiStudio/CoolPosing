# Cool Posing

VRChat-posetool voor stoere houdingen met 3-puntstracking of desktop. 50 poses: 11 staand, 9 hurkend, 14 zittend, 9 op de rug en 7 op de buik.

README voor v1.2.0 in ontwikkeling; datum nog niet vast. Versie boven in de Inspector.

- [BOOTH-productpagina](https://yunisaki.booth.pm/items/8797334)
- [Wijzigingsgeschiedenis](CHANGELOG.md)

## Weergavetaal en offline documentatie

Kies de taal bij Language / 言語 boven in de Inspector. Eén keuze geldt voor de Inspector en de gegenereerde VRChat-menu’s. Upload de avatar opnieuw om de taal in het spel te veranderen.

Zonder expliciete keuze wordt de computertaal gebruikt; niet-ondersteunde talen gebruiken Engels. Windows, macOS en Linux worden ondersteund. De laatste keuze wordt in EditorPrefs bewaard voor andere projecten van dezelfde systeemgebruiker op deze computer. Alle posehulpmiddelen en avatars gebruiken dezelfde taal. Een wijziging in de Inspector van een hulpmiddel werkt de gedeelde voorkeur bij; taalkeuzes per avatar worden genegeerd. Er is geen synchronisatie met andere computers. Licenties blijven op dezelfde manier opgeslagen. De taalknop verschijnt alleen bij de eerste installatiebevestiging als er nog geen taal is opgeslagen. Latere taalwijzigingen gebeuren in de Inspector.

Kies de taal van README, wijzigingen en handleiding in de meegeleverde [talenlijst](../index.html). De handleiding en wijzigingen in de Inspector volgen die keuze. Originele voorwaarden en referentievertalingen blijven afzonderlijk beschikbaar.

## Belangrijkste functies

- Automatische IK past positie/richting van ledematen aan in 43 poses.

- Fotomodus tot 3m vooruit en draaien; 0 bit lokaal, 16 bit voor anderen.
- Eigen hoofd zichtbaar alleen tijdens foto’s.
- Vloerhoogte verplaatst alles inclusief hoofd 3m op/neer, los van Voethoogte met vast hoofd.
- Omdraaien voor poses met zelf toegewezen bewegingen; niet meegeleverd.
- Ademhaling borst/e.d., Geen/Zwak/Gemiddeld/Sterk/Snel/Aangepast.
- Standaardwiegen onderdrukken met eigen beweging/ademhaling behouden.
- Vervorming door hoofdrotatie verminderen na nekontgrendelen.
- Gewenste functies en verbruik in Inspector.
- Zoeken, meer clips, doelvolgorde.
- Scene-voorbeeld direct uit de lijst.

- Eigen nieuwe menu-iconen voor ademhaling, Omdraaien, vloer, Fotomodus e.d. in de bestaande productstijl.

### Omdraaien instellen

Zet Omdraaien inschakelen in Details aan en wijs Zijpose voor omdraaien toe. Normale MotionTime vervalt. Activeer ook Functies > Menufuncties > Omdraaien, upload en kies pose/functie in VRChat. Nek loslaten.

Geen draai-animaties bij de meegeleverde poses. Wijs voor Omdraaien passende animaties toe.

## Ondersteunde avatarvoorinstellingen en aanpassen

Voorinstellingen voor トネール, 狛乃, 士堂 en 真央 meegeleverd.

- [トネール](https://booth.pm/ja/items/5236104)
- [狛乃](https://booth.pm/ja/items/5260363)
- [士堂](https://booth.pm/ja/items/8086741)
- [真央](https://booth.pm/ja/items/6846646)

Andere avatars werken ook; pas met Animatieaanpassing aan de bouw/wijzigingen aan. Avatarinstellingen heeft kniecorrectie en Minimale kniebuiging (graden).

IK staat standaard aan voor 43 van 50 poses; de overige 7 gebruiken eerdere individuele aanpassingen.

## Installatie

1. Download bestanden uit de gekochte winkel.
2. Importeer カッコいいポーズツール.unitypackage en registreer licentie/bron.
3. Voeg Cool Posing en Modular Avatar met VCC/ALCOM toe, met Unisaki Posing System/NDMF als afhankelijkheden.
4. Rechtsklik avatar: Unisaki Studio > Cool Posing toevoegen.
5. Kies Cool Posing in de avatar en stel functies/poses in.
6. Upload normaal.

Vereist: Unity 2022.3, VRChat Avatars SDK 3.10.4+, Modular Avatar 1.x vanaf 1.15.1 en NDMF 1.x vanaf 1.14.0. Werk benodigde pakketten samen bij met VCC/ALCOM.

## Bijwerken vanaf oudere versies

Werk product en Unisaki Posing System samen bij. Bestaande opties blijven behouden. Controleer functies/ExpressionParameters en vernieuw gebruikte voorberekening voor opnieuw uploaden.

Vanaf v1.1.0 normale 「カッコいいポーズ」-Prefab bij nieuw toevoegen. Zonder onnodige functies kost minimumselectie 8 bit; veel poses kunnen extra bits nodig hebben.

Oude 8bit-Prefabs blijven in Editor/Legacy voor bestaande avatar-/voorinstellingsverwijzingen. Niet verwijderen of vervangen. Nieuwe toevoeging toont geen 8bit.

## Waar instellen

| Tabblad | Gebruik |
| --- | --- |
| Functies | Menu’s, gemak, ademhaling, pictogrammen en parameters |
| Poses | Selectie, details, zoeken, meer clips, volgorde, voorbeeld en animatieaanpassing |
| Avatarinstellingen | Avatar-/kniecorrectie, originele/eigen beweging en voorinstellingen |

Open de instellingen voor details onder de optie. Ademhaling staat bij Functies > Gemaksfuncties > Ademhaling animeren.

Oorspronkelijke staande, hurkende en buikposes gebruiken importeert automatisch. Eigen bewegingen wijs je apart per type toe, zoals staan, hurken (Crouching), buikligging (Prone).

Voorinstellingen staan onderaan Avatarinstellingen. Deze voorinstelling toepassen vervangt de huidige poses; sla aanpassingen eerst op.

### Verbruik per functie

- Ademhaling 0 bit, schakelmenu 1 bit.
- Fotomodus lokaal 0 bit, synchronisatie 16 bit, zichtbaar hoofd 0 bit.
- Voet-/Vloerhoogte ieder 8 bit; buiten midden beweegt lichaam, nabij 50% stopt.
- Omdraaien 10 bit, met 1 bit gedeeld met hoofdcorrectie, samen 10 bit.
- Spiegelen/Gebaren uit ieder 1 bit.

Inspector-totaal is voor posetools, zonder kleding/andere systemen. Gemeenschappelijke opties tellen niet dubbel.

### Voorbeeld en bewerking

Voorbeeld toont de pose in Scene. Open Animatieaanpassing voor nauwkeurige bewerking met zicht op het resultaat en sla op.

Het lichte voorbeeld voert MA/NDMF niet uit. Bekijk ook de uiteindelijke build voor kleding en grondcorrectie voor upload.

De loep zoekt namen. Orden in Details > Volgorde of omhoog/omlaag. Sleep meerdere clips of importeer geselecteerde uit Project.

Poseminiaturen bijwerken vraagt bevestiging. Posepictogrammen helpen kiezen, maar kosten buildtijd. Verlaag pictogramformaat om ruimte te besparen. Geen pictogrammen op Android.

## Basisbediening in het spel

- Categorieposes in Expressions; hoofdhoogte wisselt staan/hurken/zitten/liggen in VR.
- Gezichtsrichting kiest rug/buik; met beide ook sprongwissel. Uit bij Functies → Gemaksfuncties → Liggende poses wisselen door springen. Menu regelt drempels.
- Desktop C/Z; ligdrempel hoger als Z niet ligt.
- Gebaren uit gebruikt posehanden.
- Voethoogte met vast hoofd; Vloerhoogte hele lichaam, in die volgorde.
- Fotomodus-Afstand beweegt/richt naar je, Richting draait. Voeten vast indien gewenst; Foto afsluiten herstelt en ontgrendelt.
- Ademhaling met actieve beweging, sterkte Unity en schakelen in spel.

## Voorberekening en waarschuwingen

Voorberekening bijwerken hergebruikt data voor snellere builds. Normale builds maken het nodige ook zonder voorberekening.

Instellingen controleren en Hierarchy-markeringen melden vernieuwing na wijzigingen. Waarschuwingsweergave zit in hetzelfde vak. Verbergen repareert of vernieuwt niet.

## Gebruiksnotities

- Geen volledige lichaamstracking voor posevergrendeling.
- Bouw/kleding/wijzigingen kunnen extra correcties vragen.
- Speciale Base/andere systemen kunnen botsen; controleer trackingintegratie onder Avatarinstellingen.
- Fotomodus/vloer corrigeren poses en standaard/eigen beweging zonder keuze; controleer blik/vervanging in VRChat.
- Standaardwiegen uit is geen oplossing voor iedere andere oorzaak.

## Handleiding en ondersteuning

Hulp / Wijzigingen bovenaan opent handleiding, hulp en geschiedenis. Gedeelde functies staan ook in Packages > Unisaki Posing System > README in Project.

- [Officiële handleiding](https://docs.unisakistudio.jp/coolposing/manual/)
- [Ondersteuning](https://help.unisakistudio.jp/)

Geef product/systeem, Unity, SDK, Modular Avatar, NDMF, avatar, stappen en Console-fout bij meldingen.

## Gebruiksvoorwaarden

Meegeleverd zijn de VN3-voorwaarden voor alle door Unisaki Studio verkochte/verspreide data: ゆにさきスタジオ販売・配布データ利用規約（日本語版）Ver1.0.0.pdf. Lees voor gebruik.

Geen open source. Rechtmatige kopers mogen broncode/bronnen binnen de meegeleverde voorwaarden gebruiken.
