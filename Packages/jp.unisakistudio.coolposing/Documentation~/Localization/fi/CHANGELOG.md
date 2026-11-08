# Muutosloki

## [1.2.0] - Julkaisematon

### Lisätty

- Inspectorin, muokkaustoimintojen, asennusikkunoiden, vakioasentojen nimien ja luotavan VRChat-valikon näyttö 30 kielellä.
- Inspectorin ja pelivalikon kielivalinnat yhdistetty. Oletuksena käytetään tietokoneen kieltä, ja viimeinen valinta koskee myös saman käyttöjärjestelmäkäyttäjän muita projekteja.
- README, muutosloki ja offline-käyttöohje voidaan avata valitulla kielellä.
- Kaikkien 128 vakioasennon näyttönimet ja toimintojen kuvaukset laadittu olemassa olevien termien mukaisesti.

### Yhteensopivuus

- Avatarin nykyiset asetukset, omat nimet, resurssiviittaukset, parametrien tunnisteet ja lisenssin tallennustapa säilyvät.

## [1.1.0] - 2026-11-07

- Mukana olevista 50 asennosta 43 mukauttaa raajat avatarin mittasuhteisiin IK:n avulla. Loput 7 käyttävät aiempia asentokohtaisia säätöjä.
- Kuvatilassa voi säätää avatarin sijaintia ja suuntaa. Voit valita sijainnin ja suunnan synkronoinnin sekä oman pään näkyvyyden kuvauksessa.
- Lattian korkeudella voi siirtää koko kehoa enintään 3m ylös tai alas. Sitä voi käyttää eri tarkoitukseen kuin jalkojen korkeutta.
- Lisätty hengitysliike, oletusarvoisen joutokäyntihuojunnan poisto ja pään suunnan aiheuttaman asennon vääristymän vähentäminen.
- Käytössä olevat toiminnot ja parametrien muistinkulutus näkyvät Inspectorissa. Lisätty asentohaku, joukkolisäys, järjestäminen ja kevyt esikatselu Scenessä.
- Nopeutettu seisoma-, kyykky- ja istuma-asentojen vaihtoa työpöytätilassa.
- Parannettu asetusmuutosten jälkeisiä esikoontivaroituksia, Inspectorin vierityksen kuormitusta ja luotujen resurssien siivouksen pitkiä pysähdyksiä.
- Lisätty Unisaki Posing System 3.1.0:n tuki.
- Mukana oleville asennoille ei toimiteta kääntymisliikkeitä.

## [1.1.0-beta.2] - Avoin beetaversio (2026-11-05)

- Mukana olevista 50 asennosta 43:lle määritetty raajojen automaattinen säätö (IK). Loput 7 käyttävät aiempia asentokohtaisia säätöjä.
- Lisätty yhteisen paketin 3.1.0-beta.2:n tuki. Tämän version mukana tuleville asennoille ei toimiteta kääntymisliikkeitä.

## [1.1.0-beta.1] - Avoin beetaversio (2026-11-04)

- Lisätty Unisaki Posing System 3.1.0-beta.1:n tuki.
- Työpöytätilan tavallinen asennonvaihto muutettu yhden arvioinnin malliin. Käytössä tavallisessa koonnissa ja esikoonnissa. VR ja erityistilanteet käyttävät aiempaa käsittelyä.
- alpha.3:n ja vanhempien versioiden esikoonnit tunnistetaan päivitettäviksi.
- Näkymä säilyy lattian korkeutta kuvauksen aikana muutettaessa. Kuvauksen jälkeen palataan uusimpaan lattian korkeuteen.
- Mukana alpha.3:een asti tehdyt automaattituonnin, tuotujen liikkeiden säädön ja luotujen Controllerien hallinnan parannukset.

## [1.1.0-alpha.1] - Ennen julkaisua

### Lisätty

- Lisätty Käänny-toiminto ja asentokohtaiset animaatioasetukset.
- Lisätty omat valikkokuvakkeet hengitykselle, kääntymiselle, lattian korkeudelle, Kuvatilalle, etäisyydelle, suunnalle ja kuvauksen lopettamiselle.
- Lisätty Kuvatila eteenpäin siirtymisen ja kierron säätämiseen.
- Lisätty Kuvatilan synkronointiasetus. Paikallinen käyttö kuluttaa 0 bit, synkronointi 16 bit.
- Lisätty asetus oman avatarin pään säilyttämiseen näkyvissä Kuvatilassa.
- Lisätty Lattian kork. -toiminto, joka nostaa koko kehoa pää mukaan lukien.
- Lisätty hengitysliike, sen voimakkuusasetukset ja pelivalikon kytkin.
- Lisätty VRChatin oletushuojunnan poisto.
- Lisätty pään suunnan aiheuttaman asennon vääristymän vähentäminen.
- Lisätty polvien taakse taittumisen esto ja vähimmäistaivutuskulma.
- Lisätty toimintokohtaiset kytkimet ja ExpressionParameters-kulutuksen näyttö.
- Lisätty kevyt esikatselu Scenessä, asentohaku, joukkolisäys ja siirtokohdan järjestysnumeron määritys.
- Lisätty muutoslokin näyttö Inspectorissa.

### Muutettu

- Inspector järjestetty 3 välilehteen: Toiminnot, Asennot ja Avatarin asetukset.
- Hengityksen lisätiedot, omien liikkeiden tuonti ja esiasetukset järjestetty selkeisiin paikkoihin.
- Vähennetty jalkojen korkeussäädön luomien animaatioiden päällekkäisyyttä.
- Asentokuvien päivitykseen lisätty vahvistusikkuna ja varoitusasetukset koottu Tarkista asetukset -kohdan sisälle.
- 8bit-version uuden asennuksen valikko poistettu ja korvattu tavallisen Prefabin toimintovalinnoilla. Nykyiset viittaukset säilyvät.
- Lisätty Unisaki Posing System 3.1.0-alpha.1:n tuki. VRChat Avatars SDK:n vähimmäisversio muutettu versioon 3.10.4.

### Korjattu

- Korjattu nimikentän syötteen siirtyminen toiseen asentoon ja lisätietojen sulkeutuminen järjestämisessä.
- Korjattu esikatselujen päällekkäisyys, sijainnin poikkeamat ja joidenkin avatarien virheet.
- Korjattu varoitusten ja esikoontitilan päivittyminen asetusmuutosten jälkeen sekä joitakin koontivirheitä.

## [1.0.0] - 2026-09-06

- Virallinen julkaisu
- Lisätty avatarien esiasetukset (トネール, 狛乃, 士堂, 真央)

## [1.0.0-alpha.1] - 2026-09-06

- Julkaisu
