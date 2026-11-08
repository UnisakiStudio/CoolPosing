# Cool Posing

Posenwerkzeug für VRChat mit coolen Haltungen für Dreipunkt-Tracking und Desktop. Enthalten sind 50 Posen: 11 Steh-, 9 Hock-, 14 Sitz-, 9 Rücken- und 7 Bauchlagen.

Diese README gilt für die in Entwicklung befindliche v1.2.0. Ein Veröffentlichungstermin steht noch nicht fest. Die installierte Version steht oben im Inspector.

- [Produktseite auf BOOTH](https://yunisaki.booth.pm/items/8797334)
- [Änderungsverlauf](CHANGELOG.md)

## Anzeigesprache und Offline-Dokumentation

Wähle die Anzeigesprache oben im Inspector unter „Language / 言語“. Die Auswahl gilt zugleich für den Inspector und die erzeugten VRChat-Menüs. Lade den Avatar erneut hoch, um die Sprache im Spiel zu ändern.

Ohne ausdrückliche Auswahl wird die Computersprache verwendet; nicht unterstützte Sprachen verwenden Englisch. Windows, macOS und Linux werden unterstützt. Die letzte Auswahl wird in EditorPrefs gespeichert und für andere Projekte desselben Betriebssystembenutzers auf diesem Computer wiederverwendet. Eine bereits ausdrücklich im Avatar gespeicherte Auswahl bleibt erhalten. Andere Computer werden nicht synchronisiert. Die Lizenzspeicherung bleibt unverändert.

README, Änderungsverlauf und Anleitung sind über die mitgelieferte [Sprachübersicht](../index.html) erreichbar. Auch die Verweise auf Anleitung und Änderungen im Inspector folgen der Auswahl. Die ursprünglichen Nutzungsbedingungen und ihre Referenzübersetzungen bleiben separat verfügbar.

## Hauptfunktionen

- Automatische Gliedmaßenanpassung (IK): passt Position und Ausrichtung in 43 Posen an den Avatarbau an.

- Fotomodus: Avatar bis 3m vorwärts bewegen und drehen. 0 bit nur lokal, 16 bit für andere sichtbare Position und Richtung.
- Kopf im Fotomodus sichtbar: verhindert nur dort das Ausblenden des nahen eigenen Avatarkopfes.
- Bodenhöhe: bewegt den ganzen Körper samt Kopf bis 3m auf oder ab; getrennt von der Fußhöhe bei fester Kopfposition.
- Umdrehen: nutzbar mit selbst zugewiesenen passenden Bewegungen. Die enthaltenen Posen liefern keine Umdrehanimationen mit.
- Atmung: Brust und weitere Teile animieren; je Kategorie Keine, Schwach, Mittel, Stark, Schnell oder Benutzerdefiniert.
- VRChat-Schwanken im Stand deaktivieren: Standardleerlauf unterdrücken und Werkzeugatmung/eigene Bewegungen erhalten.
- Verformungen durch Kopfdrehung verringern: nach Lösen der Halsfixierung durch andere Halsrichtung entstandene Verzerrungen verringern.
- Funktionsauswahl: nur gewünschte Spielmenüs ergänzen und ExpressionParameters-Verbrauch prüfen.
- Posensuche, Mehrfachimport und Sortierung: über Kategorien suchen, mehrere Clips laden und Zielreihenfolge wählen.
- Einfache Scene-Vorschau: die Haltung direkt über „Vorschau“ der Posenliste ansehen.

- Neue Menüicons: eigene, zu vorhandenen Produkticons passende Bilder für Atmung, Umdrehen, Bodenhöhe, Fotomodus und weitere Funktionen.

### Umdrehen einrichten

Aktiviere in den Details der gewünschten Liegepose „Umdrehen aktivieren“ und weise „Seitliche Umdrehpose“ eine Animation zu. Normales MotionTime ist dann nicht verfügbar. Aktiviere außerdem „Funktionen > Menüfunktionen > Umdrehen“, lade hoch und wähle in VRChat Pose und Umdrehen. Löse die Halsfixierung.

Die hier enthaltenen Posen besitzen keine Umdrehanimationen. Weise den gewünschten Posen geeignete Animationen zu.

## Unterstützte Avatarvoreinstellungen und Anpassung

Angepasste Voreinstellungen für トネール, 狛乃, 士堂 und 真央 sind enthalten.

- [トネール](https://booth.pm/ja/items/5236104)
- [狛乃](https://booth.pm/ja/items/5260363)
- [士堂](https://booth.pm/ja/items/8086741)
- [真央](https://booth.pm/ja/items/6846646)

Andere Avatare sind ebenfalls nutzbar. Passe Posen mit Animationsanpassung an Körperbau und Änderungen an. Avatareinrichtung enthält zudem „Rückwärtsknicken der Knie verhindern“ und die detaillierte „Minimale Kniebeugung (Grad)“.

Automatische Gliedmaßenanpassung (IK) ist anfangs aktiv. Von 50 Posen verwenden 43 IK, die übrigen 7 die bisherigen individuellen Anpassungen.

## Installation

1. Lade Dateien von der Produktseite des gekauften Shops herunter.
2. Importiere „カッコいいポーズツール.unitypackage“ in Unity und registriere Lizenz und Paketquelle.
3. Füge Cool Posing und Modular Avatar mit VCC oder ALCOM zum Projekt hinzu. Unisaki Posing System und NDMF werden als Abhängigkeiten installiert.
4. Rechtsklicke den Avatar in der Hierarchy und wähle „Unisaki Studio > Cool Posing hinzufügen“.
5. Wähle Cool Posing im Avatar und konfiguriere Funktionen und Posen im Inspector.
6. Lade den Avatar normal hoch.

Benötigt werden Unity 2022.3, VRChat Avatars SDK ab 3.10.4, Modular Avatar 1.x ab 1.15.1 und NDMF 1.x ab 1.14.0. Aktualisiere erforderliche Pakete gemeinsam mit VCC oder ALCOM.

## Aktualisierung älterer Versionen

Aktualisiere Produkt und Unisaki Posing System zusammen. Einstellungen bereits platzierter Werkzeuge bleiben erhalten. Prüfe Funktionen und Parameterverbrauch im Inspector; bei genutzter Vorberechnung klicke vor dem erneuten Upload auf „Vorberechnung aktualisieren“.

Seit v1.1.0 nutzen neue Installationen das normale 「カッコいいポーズ」-Prefab. Ohne unnötige Funktionen beträgt die minimale Posenauswahl 8 bit; viele Posen können zusätzliche Auswahlbits benötigen.

Alte 8bit-Prefabs bleiben unter „Editor/Legacy“, damit Referenzen bestehender Avatare und Voreinstellungen erhalten bleiben. Lösche oder ersetze bestehende Prefabs nicht. Das neue Hinzufügen bietet keine 8bit-Version an.

## Wo du Einstellungen findest

| Register | Möglichkeiten |
| --- | --- |
| Funktionen | Spielmenüs, Komfortfunktionen, Atmung, Icons und ExpressionParameters-Verbrauch |
| Posen | Auswahl, Details, Suche, Mehrfachimport, Reihenfolge, Vorschau und Animationsanpassung |
| Avatareinrichtung | Avatar- und Kniekorrekturen, ursprüngliche/eigene Bewegungen übernehmen und Voreinstellung wechseln |

Der Einstellungslink öffnet Details unter dem jeweiligen Eintrag. Atmung findest du unter „Funktionen > Komfortfunktionen > Atmung animieren“.

„Ursprüngliche Steh-, Hock- und Bauchlage verwenden“ übernimmt bestehende Avatarhaltungen automatisch. Eigene Bewegungen weist du separat in den Importoptionen je Art zu, etwa Stehen, Hocken (Crouching) oder Bauchlage (Prone).

Voreinstellungen stehen ganz unten unter „Avatareinrichtung“. „Diese Voreinstellung anwenden“ ersetzt die aktuelle Poseneinrichtung; speichere bestehende Anpassungen vorher.

### Verbrauch je Funktion

- Atembewegung benötigt 0 bit. Nur das Anhalten/Fortsetzen im Spiel unter „Menüfunktionen > Atmung“ verwendet 1 bit Synchronisierung.
- Fotomodus benötigt 0 bit nur lokal; Synchronisierung unter Komfortfunktionen benötigt 16 bit. Der sichtbare Kopf benötigt 0 bit.
- Fußhöhe und Bodenhöhe benötigen je 8 bit. Bodenhöhe außerhalb der Mitte bewegt den ganzen Körper auf/ab; nahe 50% endet sie.
- Umdrehen benötigt allein 10 bit und teilt 1 bit mit „Verformungen durch Kopfdrehung verringern“; beide zusammen also 10 bit.
- Spiegeln und Gesten aus benötigen je 1 bit.

Der Inspector-Gesamtwert umfasst die Posenwerkzeuge im Avatar, nicht Kleidung oder andere Systeme. Gemeinsam verwendete Einstellungen mehrerer Werkzeuge werden nicht doppelt gezählt.

### Vorschau und Posenbearbeitung

„Vorschau“ bei einer Pose zeigt sie in der Scene. Für genaue Änderungen öffne „Animationsanpassung“, korrigiere mit Vorschau und speichere.

Die einfache Vorschau führt MA oder NDMF nicht aus. Prüfe daher vor dem Upload auch das Build-Ergebnis für dort eingefügte Kleidung und Bodenkorrekturen.

Das Lupenregister links sucht Posennamen. Sortiere über „Details > Reihenfolge“ oder Auf-/Ab-Schaltflächen. Mehrere Animationen lassen sich hineinziehen oder über „In Project gewählte Clips übernehmen“ hinzufügen.

„Posenvorschaubilder aktualisieren“ erzeugt Bilder nach einer Bestätigung. „Posen-Icons erzeugen“ erleichtert die Auswahl im Spiel, verlängert aber die Build-Dauer. Nutze „Icongröße verringern“ zum Sparen von Speicher. Android erzeugt keine Posen-Icons.

## Grundlegende Bedienung im Spiel

- Wähle Posen je Kategorie im Expressions-Menü. In VR wechselt die Kopfhöhe zwischen Stehen, Hocken, Sitzen und Liegen.
- Im Liegen bestimmt die Gesichtsrichtung Rücken oder Bauch. Bei beiden gewählten Lagen ist auch Springen möglich, abschaltbar unter „Funktionen → Komfortfunktionen → Liegepose durch Springen wechseln“. Schwellenwerte im Menü regeln die Wechselhöhen.
- Im Desktop nutze C und Z. Erreicht Z keine Liegehaltung, erhöhe die Liegehöhenschwelle.
- Gesten aus nutzt Posenhände statt Controller-Fingerformen.
- Fußhöhe verändert die Fußseite bei festem Kopf; Bodenhöhe bewegt alles einschließlich Kopf. Beide stehen in dieser Reihenfolge.
- Fotomodus-Abstand bewegt vorwärts und richtet den Avatar zu dir. Drehe mit Richtung, fixiere Füße bei Bedarf. Foto beenden setzt Abstand/Richtung zurück und löst die Füße.
- Atmung ist bei aktiver Bewegung verfügbar; Stärke in Unity, Ein/Aus im Spiel.

## Vorberechnung und Warnungen

„Vorberechnung aktualisieren“ nutzt erzeugte Daten erneut, um Avatar-Builds zu beschleunigen. Ohne Vorberechnung erzeugt der normale Build alle erforderlichen Daten.

Nach Einstellungsänderungen melden „Einstellungen prüfen“ oben und Hierarchy-Markierungen nötige Aktualisierungen. Die Warnanzeige-Einstellungen liegen im Prüfbereich. Ausblenden behebt keine Probleme und erneuert keine Daten.

## Nutzungshinweise

- Posenfixierung mit Ganzkörper-Tracking wird nicht unterstützt.
- Körperbau, Kleidung und Änderungen können zusätzliche Anpassungen erfordern.
- Besondere Base-Layer oder andere Haltungssysteme können Integrationsprobleme haben. Prüfe bei Fixierungsfehlern „Avatareinrichtung > Tracking-Fixierungen mit anderen Werkzeugen integrieren“.
- Fotomodus und Bodenhöhe korrigieren Werkzeugposen sowie normale/eigene Bewegungen ohne Auswahl. Prüfe endgültige Blickposition und Bewegungsersetzungen im VRChat-Client.
- Die Unterdrückung des VRChat-Schwankens betrifft Standardleerlauf, nicht alle anderen Ursachen.

## Anleitung und Support

Über „Hilfe / Änderungen“ oben im Inspector öffnest du Anleitung, Support und Verlauf. Gemeinsame Funktionen sind auch unter „Packages > Unisaki Posing System > README“ im Unity-Project-Fenster erklärt.

- [Offizielle Anleitung](https://docs.unisakistudio.jp/coolposing/manual/)
- [Support](https://help.unisakistudio.jp/)

Gib bei Fehlermeldungen die Versionen des Produkts und Unisaki Posing System, Unity, VRChat SDK, Modular Avatar und NDMF, den Avatar, Reproduktionsschritte und die Console-Fehler an.

## Nutzungsbedingungen

Dieses Produkt enthält die gemeinsamen VN3-Nutzungsbedingungen für von Unisaki Studio verkaufte/verteilte Daten, „ゆにさきスタジオ販売・配布データ利用規約（日本語版）Ver1.0.0.pdf“. Lies sie vor der Verwendung.

Quellcode und Ressourcen dieses Repositorys sind nicht Open Source. Reguläre Käufer dürfen sie im Rahmen der mitgelieferten Bedingungen verwenden.
