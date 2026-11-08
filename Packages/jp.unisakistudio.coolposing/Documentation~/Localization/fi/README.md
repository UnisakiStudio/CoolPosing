# Cool Posing Tool

VRChatin asentojen lukitustyökalu, jolla voit vaihtaa tyylikkäisiin asentoihin myös 3 pisteen seurannassa ja työpöytätilassa. Mukana on yhteensä 50 asentoa: 11 seisoma-asentoa, 9 kyykkyasentoa, 14 istuma-asentoa, 9 selinmakuuasentoa ja 7 vatsamakuuasentoa.

Tämä README koskee kehitteillä olevaa versiota v1.2.0. Virallista julkaisupäivää ei ole päätetty. Asennetun version näet Inspectorin yläosasta.

- [BOOTH-tuotesivu](https://yunisaki.booth.pm/items/8797334)
- [Muutosloki](CHANGELOG.md)

## Näyttökieli ja offline-ohjeet

Valitse näyttökieli Inspectorin yläosasta kohdasta ”Language / 言語”. Sama valinta koskee Inspectoria ja luotavaa VRChat-valikkoa. Lataa avatar uudelleen palveluun, jotta pelissä näkyvä kieli vaihtuu.

Jos kieltä ei ole valittu, käytetään tietokoneen kieltä tai englantia, jos kieltä ei tueta. Windows, macOS ja Linux ovat tuettuja. Viimeksi valittu kieli tallennetaan EditorPrefsiin, ja sitä käytetään myös tämän tietokoneen saman käyttöjärjestelmäkäyttäjän muissa projekteissa. Avatariin erikseen tallennettu kielivalinta säilyy. Valintaa ei synkronoida muihin tietokoneisiin. Lisenssin tallennustapa ei muutu.

README-tiedoston, muutoslokin ja käyttöohjeen voit valita mukana toimitetusta [kieliluettelosta](../index.html). Myös Inspectorin käyttöohje ja muutosloki noudattavat valittua kieltä. Alkuperäiset käyttöehdot ja viitteelliset käännökset toimitetaan edelleen erikseen.

## Tärkeimmät toiminnot

- Raajojen automaattinen säätö (IK): mukauttaa raajojen sijainnin ja suunnan avatarin mittasuhteisiin 43 asennossa.

- Kuvatila: siirrä avataria enintään 3m eteenpäin ja säädä sen suuntaa. Käyttö vain omalla näytöllä kuluttaa 0 bit. Sijainnin ja suunnan näyttäminen muille kuluttaa 16 bit.
- Pään näkyvyys kuvauksessa: estää lähellä olevan oman avatarisi pään piilottamisen vain Kuvatilan ajaksi.
- Lattian kork.: siirtää koko kehoa pää mukaan lukien enintään 3m ylös tai alas. Se täydentää Jalkojen kork. -toimintoa, joka liikuttaa jalkojen puolta pitäen pään paikallaan.
- Käänny: käytettävissä asennoissa, joille määrität itse sopivan liikkeen. Mukana toimitetuissa asennoissa ei ole kääntymisliikkeitä.
- Hengitys: lisää hengitysliikettä esimerkiksi rintaan. Valitse asentoluokittain Ei mitään, Heikko, Keskivahva, Vahva, Nopea tai Oma.
- Poista VRChatin oletushuojunta: vähentää oletusarvoista joutokäyntihuojuntaa säilyttäen työkalun hengityksen ja muut omat liikkeet.
- Vähennä pään kierrosta aiheutuvaa asennon vääristymää: vähentää alkuperäisestä asennosta poikkeavan pään suunnan aiheuttamaa vääristymää pään lukituksen vapautuessa.
- Toimintojen valinta: lisää vain tarvitsemasi pelivalikot ja tarkista ExpressionParameters-kulutus Inspectorista.
- Asentoluettelon haku, joukkolisäys ja järjestäminen: hae kaikista luokista, tuo useita leikkeitä ja määritä siirtokohdan järjestys.
- Kevyt esikatselu Scenessä: tarkista asento suoraan asentoluettelon Esikatselu-toiminnolla.

- Uusien toimintojen valikkokuvakkeet: hengitykselle, kääntymiselle, lattian korkeudelle, Kuvatilalle ja muille toiminnoille on omat kuvat, jotka sopivat tuotteen nykyisiin kuvakkeisiin.

### Käänny-toiminnon määrittäminen

Ota haluamasi makuuasennon Lisätiedoista ”Ota Käänny käyttöön” käyttöön ja määritä animaatio kohtaan ”Käänny-toiminnon sivuasento”. Tavallinen MotionTime-asetus ei ole käytettävissä. Ota myös ”Toiminnot > Valikkotoiminnot > Käänny” käyttöön ja lataa avatar palveluun. Valitse VRChatissa tuettu asento ja Käänny-toiminto. Vapauta pään lukitus ennen käyttöä.

Tällä kertaa mukana toimitetuissa asennoissa ei ole kääntymisliikkeitä. Määritä haluamaasi asentoon sopiva animaatio.

## Tuetut avatarien esiasetukset ja säätäminen

Mukana on valmiiksi säädetyt esiasetukset avatareille トネール, 狛乃, 士堂 ja 真央.

- [トネール](https://booth.pm/ja/items/5236104)
- [狛乃](https://booth.pm/ja/items/5260363)
- [士堂](https://booth.pm/ja/items/8086741)
- [真央](https://booth.pm/ja/items/6846646)

Työkalua voi käyttää myös muilla avatareilla. Säädä asennot mittasuhteisiin ja muutoksiin sopiviksi Animaatiosäädöllä. Avatarin asetuksissa ovat myös ”Estä polvien taittuminen taakse” ja sen lisätietojen ”Polven vähimmäistaivutus (asteina)”.

Raajojen automaattinen säätö (IK) on oletuksena käytössä. Mukana olevista 50 asennosta 43 käyttää IK:ta. Loput 7 käyttävät aiempia asentokohtaisia säätöjä.

## Asennus

1. Lataa tiedostot ostamasi kaupan tuotesivulta.
2. Tuo mukana oleva ”カッコいいポーズツール.unitypackage” Unityyn ja rekisteröi lisenssi sekä pakettien jakelulähde.
3. Lisää Cool Posing Tool ja Modular Avatar Unity-projektiin VCC:llä tai ALCOMilla. Yhteinen Unisaki Posing System ja NDMF asennetaan riippuvuuksina.
4. Napsauta kohdeavataria Hierarchyssa hiiren oikealla painikkeella ja valitse ”Unisaki Studio > Lisää Cool Posing”.
5. Valitse avatariin lisätty ”カッコいいポーズ (Cool Posing)” ja määritä haluamasi toiminnot ja asennot Inspectorissa.
6. Lataa avatar palveluun tavalliseen tapaan.

Vaatimukset ovat Unity 2022.3, VRChat Avatars SDK 3.10.4 tai uudempi, Modular Avatar 1.x vähintään 1.15.1 ja NDMF 1.x vähintään 1.14.0. Päivitä tarvittavat paketit yhdessä VCC:llä tai ALCOMilla.

## Päivittäminen vanhemmasta versiosta

Päivitä tämä tuote ja Unisaki Posing System yhdessä. Kohtaukseen sijoitettujen työkalujen asetukset säilyvät. Tarkista käytössä olevat toiminnot ja ExpressionParameters-kulutus Inspectorista. Jos käytit esikoontia, paina ”Päivitä esikoonti” ennen uudelleenlatausta.

Versiosta v1.1.0 lähtien uusi asennus käyttää aina tavallista カッコいいポーズ (Cool Posing) -Prefabia. Poista tarpeettomat toiminnot käytöstä Toiminnot-välilehdessä, jolloin pelkän asennonvalinnan vähimmäiskulutus on 8 bit. Suuri asentomäärä voi vaatia lisää bittejä asennon valintaan.

Vanha 8bit-Prefab säilytetään Editor/Legacy-kansiossa olemassa olevien avatarien ja esiasetusten viittausten säilyttämiseksi. Nykyisiä Prefabeja ei tarvitse poistaa tai korvata. 8bit-versiota ei näytetä Unityn uuden asennuksen valikossa.

## Asetusten sijainti

| Välilehti | Toiminnot |
| --- | --- |
| Toiminnot | Pelivalikoiden lisääminen, lisätoiminnot, hengitysasetukset sekä kuvakkeiden ja ExpressionParameters-kulutuksen tarkistus |
| Asennot | Käytettävien asentojen valinta, lisätiedot, haku, joukkolisäys, järjestäminen, esikatselu ja animaatiosäätö |
| Avatarin asetukset | Avatarikohtainen korjaus, polvikorjaus, alkuperäisten asentojen ja omien liikkeiden tuonti sekä esiasetusten vaihto |

Avaa asetukset näyttää tarkat asetukset kyseisen kohdan alapuolella. Hengitystä säädetään kohdasta ”Toiminnot > Lisätoiminnot > Animoi hengitys”.

”Käytä alkuperäisiä seisoma-, kyykky- ja vatsa-asentoja” tuo avatarin olemassa olevat asennot automaattisesti. Jos käytät omia liikkeitä, avaa erilliset tuontiasetukset ja määritä ne tyypeittäin, esimerkiksi seisominen, kyykky (Crouching) ja vatsamakuu (Prone).

Esiasetukset löytyvät Avatarin asetukset -välilehden lopusta. ”Käytä tätä esiasetusta” korvaa nykyiset asentoasetukset, joten tallenna tekemäsi säädöt ennen vaihtamista.

### Toimintokohtainen muistinkulutus

- Hengitysliike kuluttaa 0 bit. Vain jos käytät pelin pysäytys- ja jatkokytkintä ”Valikkotoiminnot > Hengitys”, kytkimen synkronointi kuluttaa 1 bit.
- Kuvatila kuluttaa 0 bit vain omalla näytöllä. ”Lisätoiminnot > Synkronoi Kuvatila” kuluttaa 16 bit. ”Pidä pää näkyvissä Kuvatilassa” kuluttaa 0 bit.
- ”Jalkojen kork.” ja ”Lattian kork.” kuluttavat kumpikin 8 bit. Lattian korkeuden siirtäminen keskeltä liikuttaa koko kehoa pystysuunnassa. Paluu lähelle 50% lopettaa toiminnon.
- ”Käänny” kuluttaa yksin 10 bit. Se jakaa 1 bit pään kierrosta aiheutuvan asennon vääristymän vähentämisen kanssa, joten molempien yhteiskulutus on 10 bit.
- ”Peilaa” ja ”Eleet pois” kuluttavat kumpikin 1 bit.

Inspectorin yhteismäärä koskee avatariin asennettuja asentotyökaluja. Asujen tai muiden toimintojen kulutus ei sisälly siihen. Usean asentotyökalun yhteisiä asetuksia ei lasketa kahdesti.

### Esikatselu ja asentojen muokkaus

Voit näyttää asennon Scenessä Asennot-välilehden asentokohtaisella Esikatselu-toiminnolla. Jos haluat muokata sitä tarkemmin, avaa Animaatiosäätö, tarkista ja säädä asentoa sekä tallenna.

Kevyt esikatselu ei suorita MA:n tai NDMF:n koontikäsittelyä. Tarkista myös koontitulos ennen latausta, sillä asu ja lattian sijainnin korjaus voivat tulla mukaan vasta koonnissa.

Vasemman reunan suurennuslasivälilehdessä voit hakea asentoa nimellä. Voit järjestää asentoja Lisätiedot-kohdan Järjestys-valikolla tai ylös- ja alas-painikkeilla. Lisää useita animaatioita vetämällä ne lisäyskenttään tai tuomalla Projectissa valitut leikkeet.

”Päivitä asentojen pikkukuvat” luo kuvat vahvistusikkunan jälkeen. ”Luo asentokuvakkeet” helpottaa asentojen tunnistamista pelivalikossa, mutta kuvien luonti pidentää koontiaikaa. Valitse ”Pienennä kuvakkeita” vähentääksesi kokoa. Androidille asentokuvakkeita ei luoda.

## Pelin perusohjaimet

- Valitse asento kullekin luokalle Expressions-valikosta. VR:ssä seisoma-, kyykky-, istuma- ja makuuasentojen välillä vaihdetaan pään korkeuden mukaan.
- Makuuasennossa kasvojen suunta vaihtaa selin- ja vatsamakuun välillä. Jos molemmat on valittu, myös hyppääminen vaihtaa niiden välillä. Tämän voi poistaa käytöstä kohdasta ”Toiminnot → Lisätoiminnot → Vaihda makuuasentoa hyppäämällä”. Luokkien vaihtumiskorkeutta säädetään asetusvalikon raja-arvoilla.
- Työpöytätilassa vaihda asentoa C- ja Z-näppäimillä. Jos Z ei vaihda makuuasentoon, nosta makuuasennon korkeusrajaa asetusvalikossa.
- ”Eleet pois” käyttää asennon määrittämää kädenmuotoa ohjaimen sormieleen sijaan.
- ”Jalkojen kork.” säätää jalkojen puolta pitäen pään paikallaan. ”Lattian kork.” siirtää koko kehoa pää mukaan lukien pystysuunnassa. Ne ovat tässä järjestyksessä asetusvalikossa.
- Kun siirryt Kuvatilan Etäisyys-säätimellä eteenpäin, avatar kääntyy sinua kohti. Kierrä Suunta-säätimellä ja ota ”Lukitse jalat” käyttöön sopivalla hetkellä. ”Lopeta kuvaus” palauttaa etäisyyden ja suunnan sekä vapauttaa jalkojen lukituksen.
- Hengitys on käytettävissä, kun hengitysliike on käytössä. Voimakkuus asetetaan Unityssa. Pelissä vaihdetaan toiminnon kytkintä.

## Esikoonti ja varoitukset

”Päivitä esikoonti” nopeuttaa avatarin koontia käyttämällä luotua dataa uudelleen. Myös ilman esikoontia tavallinen koonti luo tarvittavan datan.

Asetusmuutosten jälkeen Inspectorin yläosan ”Tarkista asetukset” ja Hierarchyn merkki ilmoittavat päivitystarpeesta. ”Varoitusten näyttöasetukset” on Tarkista asetukset -kehyksessä. Näytön piilottaminen ei ratkaise asetusongelmia eikä päivitä luotua dataa.

## Huomioita käytöstä

- Asennon lukitusta kokovartaloseurannassa ei tueta.
- Mittasuhteet, asu ja avatarin muutokset voivat edellyttää lisäsäätöjä.
- Erityiset Base-tasot tai muut asentoa muuttavat toiminnot eivät välttämättä yhdisty odotetusti. Jos lukitus ei toimi, tarkista myös ”Avatarin asetukset > Yhdistä seurantalukitukset muihin työkaluihin”.
- Kuvatilan liike, kierto ja lattian korkeus korjaavat työkalun asennot sekä oletus- ja omat liikkeet silloin, kun asentoa ei ole valittu. Tarkista lopullinen näkymä ja liikkeiden korvaamisen jälkeinen toiminta VRChat-asiakasohjelmassa.
- ”Poista VRChatin oletushuojunta” koskee oletusarvoista joutokäyntiliikettä. Se ei pysäytä kaikista muista syistä syntyvää huojuntaa.

## Käyttöohjeet ja tuki

Inspectorin yläosan ohje- ja muutoslokkipaneelista voit avata käyttöohjeet, tuen ja muutoslokin. Yhteisten toimintojen tarkemmat ohjeet ovat myös Unityn Project-näkymässä kohdassa ”Packages > Unisaki Posing System > README”.

- [Virallinen käyttöohje](https://docs.unisakistudio.jp/coolposing/manual/)
- [Ota yhteyttä](https://help.unisakistudio.jp/)

Liitä virheilmoitukseen tämän tuotteen ja Unisaki Posing Systemin versiot, Unityn, VRChat SDK:n, Modular Avatarin ja NDMF:n versiot, käytetty avatar, toistamisohjeet sekä Consolen virheteksti.

## Käyttöehdot

Tuotteen mukana toimitetaan Unisaki Studion myymään ja jakamaan dataan yhteisesti sovellettavat VN3-käyttöehdot tiedostossa ”ゆにさきスタジオ販売・配布データ利用規約（日本語版）Ver1.0.0.pdf”. Lue ne ennen käyttöä.

Tämän repositorion lähdekoodi ja resurssit eivät ole avointa lähdekoodia. Laillisille ostajille myönnetään käyttöoikeus mukana toimitettujen käyttöehtojen rajoissa.
