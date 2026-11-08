# Historie změn

## [1.2.0] - Nevydáno

### Přidáno

- Zobrazení Inspectoru, úprav, instalačních dialogů, standardních názvů póz a generované nabídky VRChat ve 30 jazycích.
- Sjednocen výběr jazyka Inspectoru a herní nabídky. Výchozí je jazyk počítače a poslední volba platí i pro další projekty stejného uživatele OS.
- README, historie změn a offline návod se otevírají ve vybraném jazyce.
- Připraveny názvy všech 128 standardních póz a popisy funkcí podle stávající terminologie.

### Kompatibilita

- Zachovávají se existující nastavení avatara, vlastní názvy, odkazy na prostředky, identifikátory parametrů a způsob ukládání licencí.

## [1.1.0] - 2026-11-07

- U 43 z 50 přiložených póz se končetiny automaticky přizpůsobují proporcím pomocí IK. Zbývajících 7 používá dosavadní individuální korekce.
- Režim focení umožňuje upravit polohu a směr avatara. Lze zvolit synchronizaci polohy a směru i zobrazení vlastní hlavy při focení.
- Výška podlahy posouvá celé tělo až 3m nahoru či dolů a doplňuje výšku chodidel.
- Přidáno dýchání, vypnutí výchozího pohupování v klidu a omezení deformace pózy podle směru hlavy.
- Používané funkce a spotřeba parametrů jsou viditelné v Inspectoru. Přidáno hledání póz, hromadné přidání, řazení a lehký náhled v Scene.
- Zrychleno přepínání stoje, podřepu a sedu v režimu plochy.
- Zlepšena varování po změně nastavení předgenerování, zátěž posouvání Inspectoru a dlouhá zastavení při úklidu prostředků.
- Přidána podpora Unisaki Posing System 3.1.0.
- Pohyby přetočení pro přiložené pózy nejsou zahrnuty.

## [1.1.0-beta.2] - Otevřená beta (2026-11-05)

- Automatická korekce končetin (IK) nastavena pro 43 z 50 přiložených póz. Zbývajících 7 používá dosavadní individuální korekce.
- Přidána podpora společného balíčku 3.1.0-beta.2. Pózy této verze neobsahují přiložené pohyby přetočení.

## [1.1.0-beta.1] - Otevřená beta (2026-11-04)

- Přidána podpora Unisaki Posing System 3.1.0-beta.1.
- Běžné přepínání póz v režimu plochy převedeno na jedno vyhodnocení. Funguje při běžném sestavení i předgenerování, VR a zvláštní podmínky zachovávají dosavadní cestu.
- Předgenerování z alpha.3 a starších verzí se rozpoznává jako vyžadující aktualizaci.
- Při změně výšky podlahy během focení se zachovává pohled a po ukončení se obnoví poslední výška podlahy.
- Zahrnuta zlepšení automatického importu, úprav importovaných pohybů a správy vytvořených Controllerů až do alpha.3.

## [1.1.0-alpha.1] - Před zveřejněním

### Přidáno

- Přidáno přetočení a nastavení odpovídajících animací jednotlivých póz.
- Přidány samostatné ikony nabídky pro dýchání, přetočení, výšku podlahy, režim focení, vzdálenost, směr a ukončení focení.
- Přidán režim focení pro posun vpřed a otáčení.
- Přidána synchronizace režimu focení: pouze lokálně 0 bit, se synchronizací 16 bit.
- Přidáno ponechání vlastní hlavy viditelné v režimu focení.
- Přidána Výška podlahy, která zvedá celé tělo včetně hlavy.
- Přidán pohyb a intenzita dýchání i herní přepínač.
- Přidáno vypnutí výchozího pohupování VRChat.
- Přidáno omezení deformace pózy podle směru hlavy.
- Přidáno zabránění ohybu kolen dozadu a minimální úhel ohybu.
- Přidány přepínače funkcí a zobrazení spotřeby ExpressionParameters.
- Přidán lehký náhled v Scene, hledání póz, hromadné přidávání a volba cílového pořadí.
- Přidána historie změn v Inspectoru.

### Změněno

- Inspector rozdělen na 3 karty: Funkce, Pózy a Nastavení avatara.
- Uspořádáno umístění podrobností dýchání, importu vlastních pohybů a předvoleb.
- Omezeno opakování animací vytvářených pro výšku chodidel.
- Přidán potvrzovací dialog obnovy obrázků póz a nastavení varování soustředěno do Kontroly nastavení.
- Odstraněna nabídka nového přidání 8bit verze, nahrazena volbou funkcí běžného Prefabu. Existující odkazy zůstávají.
- Přidána podpora Unisaki Posing System 3.1.0-alpha.1. Minimální verze VRChat Avatars SDK změněna na 3.10.4.

### Opraveno

- Opraven přesun zadávaného názvu na jinou pózu a zavírání podrobností při řazení.
- Opraveno překrývání náhledů, odchylka umístění a chyby některých avatarů.
- Opraveno obnovování varování a stavu předgenerování po změně nastavení i některé chyby sestavení.

## [1.0.0] - 2026-09-06

- Oficiální vydání
- Přidány předvolby avatarů (トネール, 狛乃, 士堂, 真央)

## [1.0.0-alpha.1] - 2026-09-06

- Vydání
