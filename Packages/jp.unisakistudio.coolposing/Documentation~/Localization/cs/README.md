# Cool Posing Tool

Nástroj pro zamykání póz ve VRChat, který umožňuje působivé pózy i se sledováním 3 bodů a v režimu plochy. Obsahuje celkem 50 póz: 11 ve stoje, 9 v podřepu, 14 vsedě, 9 na zádech a 7 na břiše.

Tento README je určen pro vyvíjenou verzi v1.2.0. Datum oficiálního vydání zatím nebylo stanoveno. Nainstalovaná verze se zobrazuje nahoře v Inspectoru.

- [Stránka produktu na BOOTH](https://yunisaki.booth.pm/items/8797334)
- [Historie změn](CHANGELOG.md)

## Jazyk rozhraní a offline dokumentace

Vyberte jazyk v poli „Language / 言語“ nahoře v Inspectoru. Jedna volba řídí Inspector i vytvářenou nabídku VRChat. Pro změnu jazyka ve hře avatara znovu nahrajte.

Pokud jazyk není vybrán, použije se jazyk počítače; nepodporované jazyky přejdou na angličtinu. Podporovány jsou Windows, macOS a Linux. Poslední volba se ukládá do EditorPrefs a používá se i v dalších projektech stejného uživatele OS na tomto počítači. Výslovná volba uložená v avatarovi zůstává zachována. Mezi počítači se nesynchronizuje. Způsob ukládání licencí se nemění.

README, historii změn a návod lze vybrat v přiloženém [seznamu jazyků](../index.html). Návod a historie změn v Inspectoru také používají vybraný jazyk. Původní podmínky použití a referenční překlady jsou nadále dodávány samostatně.

## Hlavní funkce

- Automatická korekce končetin (IK): přizpůsobuje polohu a směr rukou a nohou proporcím avatara u 43 póz.

- Režim focení: posune avatara až 3m dopředu a upraví směr. Jen na vlastní obrazovce spotřebuje 0 bit, zobrazení polohy a směru ostatním 16 bit.
- Zobrazení hlavy při focení: zabrání skrytí hlavy vlastního avatara zblízka pouze během režimu focení.
- Výška podlahy: posune celé tělo včetně hlavy až 3m nahoru či dolů. Doplňuje Výšku chodidel, která upravuje stranu nohou při zachování hlavy.
- Přetočit se: lze použít u póz, kterým sami přiřadíte odpovídající pohyb. Přiložené pózy neobsahují pohyby přetočení.
- Dýchání: přidává pohyb například hrudníku. Pro každou kategorii lze vybrat Žádné, Slabé, Střední, Silné, Rychlé nebo Vlastní.
- Vypnout pohupování VRChat v klidu: omezuje výchozí pohupování a zachovává dýchání nástroje i další vlastní pohyby.
- Omezit deformaci pózy při otočení hlavy: omezuje deformaci po odemknutí hlavy, pokud její směr neodpovídá původní póze.
- Volba funkcí: přidává jen potřebné herní nabídky a ukazuje spotřebu ExpressionParameters v Inspectoru.
- Hledání, hromadné přidání a řazení póz: hledání napříč kategoriemi, načtení více klipů a určení cílového pořadí.
- Lehký náhled v Scene: kontrola pózy přímo ze seznamu pomocí Náhledu.

- Ikony nabídky nových funkcí: dýchání, přetočení, výška podlahy, režim focení a další funkce mají vlastní obrázky sladěné se stávajícími ikonami produktu.

### Nastavení přetočení

V Podrobnostech požadované ležící pózy zapněte Zapnout přetočení a přiřaďte animaci do Boční pózy přetočení. Běžné MotionTime se stane nedostupné. Zapněte také „Funkce > Funkce nabídky > Přetočit se“ a nahrajte avatara. Ve VRChat vyberte podporovanou pózu a Přetočit se. Hlavu před použitím odemkněte.

Přiložené pózy této verze neobsahují pohyby přetočení. Přiřaďte animaci odpovídající požadované póze.

## Podporované předvolby avatarů a přizpůsobení

Přiloženy jsou upravené předvolby pro トネール, 狛乃, 士堂 a 真央.

- [トネール](https://booth.pm/ja/items/5236104)
- [狛乃](https://booth.pm/ja/items/5260363)
- [士堂](https://booth.pm/ja/items/8086741)
- [真央](https://booth.pm/ja/items/6846646)

Lze používat i jiné avatary. Přizpůsobte pózy pomocí Úpravy animace podle proporcí a úprav. V Nastavení avatara jsou také Zabránit ohybu kolen dozadu a Minimální ohyb kolena (stupně) v podrobnostech.

Automatická korekce končetin (IK) je ve výchozím stavu zapnutá. Z 50 přiložených póz používá IK 43 a zbývajících 7 dosavadní individuální korekce.

## Instalace

1. Stáhněte soubory ze stránky produktu v obchodě, kde jste nakoupili.
2. Importujte přiložený „カッコいいポーズツール.unitypackage“ do Unity a zaregistrujte licenci i zdroj balíčků.
3. Přes VCC nebo ALCOM přidejte Cool Posing Tool a Modular Avatar do požadovaného projektu Unity. Společný Unisaki Posing System a NDMF se nainstalují jako závislosti.
4. Klikněte pravým tlačítkem na cílového avatara v Hierarchy a zvolte „Unisaki Studio > Přidat Cool Posing“.
5. Vyberte カッコいいポーズ (Cool Posing) přidaný do avatara a nastavte v Inspectoru požadované funkce a pózy.
6. Nahrajte avatara běžným způsobem.

Požadováno je Unity 2022.3, VRChat Avatars SDK 3.10.4 nebo novější, Modular Avatar 1.x od 1.15.1 a NDMF 1.x od 1.14.0. Aktualizujte potřebné balíčky společně přes VCC nebo ALCOM.

## Aktualizace ze starší verze

Aktualizujte tento produkt a Unisaki Posing System společně. Nastavení již umístěných nástrojů se zachová. Zkontrolujte funkce a spotřebu ExpressionParameters v Inspectoru. Pokud jste používali předgenerování, před novým nahráním stiskněte Aktualizovat předgenerování.

Od v1.1.0 používají nová přidání běžný Prefab カッコいいポーズ (Cool Posing). Vypnutím nepotřebných funkcí získáte minimální konfiguraci jen s výběrem póz za 8 bit. Velký počet póz může vyžadovat další bity pro výběr.

Starý 8bit Prefab zůstává v Editor/Legacy pro zachování odkazů existujících avatarů a předvoleb. Není nutné jej mazat ani nahrazovat. V nabídce nového přidání Unity se 8bit verze nezobrazuje.

## Umístění nastavení

| Karta | Možnosti |
| --- | --- |
| Funkce | Přidání herních nabídek, usnadnění, dýchání a kontrola ikon i spotřeby ExpressionParameters |
| Pózy | Výběr používaných póz, podrobnosti, hledání, hromadné přidání, pořadí, náhled a úprava animace |
| Nastavení avatara | Korekce avatara a kolen, import původních póz a vlastních pohybů, změna předvoleb |

Otevřít nastavení rozbalí podrobné možnosti pod příslušnou položkou. Dýchání se nastavuje přes „Funkce > Usnadnění > Animovat dýchání“.

Použít původní pózy ve stoje, v přikrčení a na břiše automaticky importuje existující pózy avatara. Vlastní pohyby se přiřazují samostatně přes nastavení importu pro každý typ, například stoj, přikrčení (Crouching) a leh na břiše (Prone).

Předvolby jsou dole v Nastavení avatara. Použít tuto předvolbu nahrazuje aktuální nastavení póz, proto před změnou uložte hotové úpravy.

### Spotřeba jednotlivých funkcí

- Pohyb dýchání používá 0 bit. Jen herní přepínač zastavení a spuštění „Funkce nabídky > Dýchání“ používá 1 bit pro synchronizaci.
- Režim focení pouze na vlastní obrazovce používá 0 bit. „Usnadnění > Synchronizovat režim focení“ používá 16 bit. Ponechat hlavu viditelnou v režimu focení používá 0 bit.
- Výška chodidel i Výška podlahy používají každá 8 bit. Odchýlení výšky podlahy od středu posune celé tělo nahoru či dolů a návrat přibližně k 50% ukončí akci.
- Přetočení samostatně používá 10 bit. Sdílí 1 bit s omezením deformace při otočení hlavy, proto obě funkce dohromady používají 10 bit.
- Zrcadlit a Gesta vyp. používají každá 1 bit.

Součet v Inspectoru se týká nástrojů pro pózy instalovaných na avatarovi. Nezahrnuje oblečení ani jiné funkce. Společná nastavení více nástrojů se nepočítají opakovaně.

### Náhled a úprava póz

Náhled u každé pózy na kartě Pózy ji zobrazí v Scene. Pro jemné změny otevřete Úpravu animace, upravte pózu s náhledem a uložte.

Lehký náhled neprovádí sestavení MA ani NDMF. Oblečení a korekci polohy podlahy přidávané během sestavení ověřte i v sestaveném výsledku před nahráním.

Karta s lupou vlevo hledá názvy póz. Cílové místo vyberete v „Podrobnosti > Pořadí“ nebo tlačítky nahoru a dolů. Více animací přidáte přetažením do přidávací oblasti nebo příkazem pro import klipů vybraných v Project.

Aktualizovat obrázky póz generuje obrázky po potvrzení. Generovat ikony póz usnadňuje rozlišení v herní nabídce, ale vytváření obrázků prodlužuje sestavení. Pro snížení velikosti zvolte Zmenšit velikost ikon. Pro Android se ikony póz negenerují.

## Základní ovládání ve hře

- V nabídce Expressions vyberte pózy jednotlivých kategorií. Ve VR se stoj, podřep, sed a leh přepínají podle výšky hlavy.
- Vleže směr obličeje přepíná záda a břicho. Pokud jsou vybrány obě pózy, lze přepínat skokem; vypnete to přes „Funkce → Usnadnění → Měnit ležící pózy skokem“. Výšku přepínání kategorií upravují prahy v nastavení.
- V režimu plochy přepínejte klávesami C a Z. Pokud Z nepřepne do lehu, zvyšte práh výšky pro leh v nastavení.
- Gesta vyp. používá tvar rukou z pózy místo gest prstů ovladače.
- Výška chodidel upravuje stranu nohou při zachování hlavy. Výška podlahy posouvá celé tělo včetně hlavy svisle. V nastavení jsou v tomto pořadí.
- Posun dopředu pomocí Vzdálenosti v režimu focení obrátí avatara k vám. Směr jej otáčí a Zamknout nohy zapněte ve vhodnou chvíli. Ukončit focení obnoví vzdálenost i směr a odemkne nohy.
- Dýchání je dostupné, pokud je pohyb dýchání zapnutý. Intenzita se nastavuje v Unity a ve hře se přepíná zapnutí.

## Předgenerování a varování

Aktualizovat předgenerování urychluje sestavení avatara znovupoužitím vytvořených dat. Bez předgenerování potřebná data vzniknou při běžném sestavení.

Po změně nastavení upozorňují na aktualizaci Kontrola nastavení nahoře v Inspectoru a značka Hierarchy. Zobrazení varování je uvnitř rámečku Kontrola nastavení. Skrytí zobrazení neřeší problém konfigurace ani neobnovuje vytvořená data.

## Poznámky k používání

- Zamykání póz při celotělovém sledování není podporováno.
- Proporce, oblečení a úpravy avatara mohou vyžadovat další doladění.
- Zvláštní vrstvy Base a jiné systémy změny póz se nemusejí spojit podle očekávání. Pokud zámky nefungují, ověřte „Nastavení avatara > Propojit zámky sledování s dalšími nástroji“.
- Pohyb a otáčení režimu focení i výška podlahy korigují pózy nástroje i výchozí a vlastní pohyby bez vybrané pózy. Ověřte konečný pohled a chování po nahrazení pohybů v klientu VRChat.
- Vypnout pohupování VRChat v klidu se týká výchozího klidového pohybu. Nezastavuje veškeré pohupování z jiných příčin.

## Návod a podpora

Horní panel nápovědy a historie změn v Inspectoru otevírá návod, kontakt a historii změn. Podrobné vysvětlení společných funkcí najdete také v Project Unity pod „Packages > Unisaki Posing System > README“.

- [Oficiální návod](https://docs.unisakistudio.jp/coolposing/manual/)
- [Kontaktovat podporu](https://help.unisakistudio.jp/)

Při hlášení chyby uveďte verze tohoto produktu a Unisaki Posing System, Unity, VRChat SDK, Modular Avatar a NDMF, použitého avatara, kroky k reprodukci a text chyby Console.

## Podmínky použití

Produkt obsahuje společné podmínky VN3 pro data prodávaná a distribuovaná Unisaki Studio v souboru „ゆにさきスタジオ販売・配布データ利用規約（日本語版）Ver1.0.0.pdf“. Před použitím si je přečtěte.

Zdrojový kód a prostředky tohoto repozitáře nejsou open source. Řádným kupujícím se povoluje použití v rozsahu přiložených podmínek.
