# Cool Posing Tool

Narzędzie blokowania poz dla VRChat, pozwalające przyjmować efektowne pozy także przy śledzeniu 3 punktów i w trybie pulpitu. Zawiera 50 poz: 11 stojących, 9 kucających, 14 siedzących, 9 na plecach i 7 na brzuchu.

Ten README dotyczy tworzonej wersji v1.2.0. Data oficjalnego wydania nie została ustalona. Zainstalowana wersja jest widoczna u góry Inspectora.

- [Strona produktu w BOOTH](https://yunisaki.booth.pm/items/8797334)
- [Historia zmian](CHANGELOG.md)

## Język interfejsu i dokumentacja offline

Wybierz język w polu „Language / 言語” u góry Inspectora. Jeden wybór obejmuje Inspector i generowane menu VRChat. Aby zmienić język w grze, prześlij awatara ponownie.

Jeżeli nie wybrano języka, używany jest język komputera, a dla nieobsługiwanego języka — angielski. Obsługiwane są Windows, macOS i Linux. Ostatni wybór jest zapisywany w EditorPrefs i używany także w innych projektach tego samego użytkownika systemu na tym komputerze. Wszystkie narzędzia do pozowania i awatary używają tego samego języka. Zmiana w Inspectorze dowolnego narzędzia aktualizuje wspólne ustawienie; wybory języka poszczególnych awatarów są ignorowane. Nie jest synchronizowany z innymi komputerami. Sposób przechowywania licencji nie zmienia się. Przycisk języka pojawia się tylko przy pierwszym potwierdzeniu instalacji, gdy nie zapisano języka. Późniejszych zmian dokonuje się w Inspectorze.

README, historię zmian i instrukcję można wybrać z dołączonej [listy języków](../index.html). Przyciski instrukcji i historii zmian w Inspectorze również uwzględniają wybrany język. Oryginalne warunki użytkowania i tłumaczenia pomocnicze nadal są dostarczane osobno.

## Główne funkcje

- Automatyczna korekcja kończyn (IK): dopasowuje położenie i kierunek rąk oraz nóg do budowy awatara w 43 pozach.

- Tryb zdjęć: przesuń awatara do 3m do przodu i dopasuj kierunek. Tylko na własnym ekranie zużywa 0 bit, a pokazywanie pozycji i kierunku innym — 16 bit.
- Widoczność głowy podczas zdjęć: zapobiega ukrywaniu głowy własnego awatara z bliska tylko w trybie zdjęć.
- Wysokość ziemi: przesuwa całe ciało wraz z głową do 3m w górę lub w dół. Uzupełnia Wysokość stóp, która reguluje stronę nóg z zachowaniem głowy.
- Obróć się: dostępne w pozach, którym samodzielnie przypiszesz odpowiedni ruch. Dołączone pozy nie zawierają ruchów obracania.
- Oddech: dodaje ruch, np. klatki piersiowej. Dla każdej kategorii można wybrać Brak, Słabe, Średnie, Silne, Szybkie lub Własne.
- Wyłącz kołysanie w spoczynku VRChat: ogranicza standardowe kołysanie, zachowując oddech narzędzia i inne własne ruchy.
- Ogranicz deformację pozy przy obrocie głowy: zmniejsza deformację po zwolnieniu blokady, gdy kierunek głowy różni się od oryginalnej pozy.
- Wybór funkcji: dodawaj tylko potrzebne menu gry i sprawdzaj zużycie ExpressionParameters w Inspectorze.
- Wyszukiwanie, dodawanie zbiorcze i sortowanie poz: wyszukiwanie między kategoriami, wczytywanie wielu klipów i wybór miejsca w kolejności.
- Uproszczony podgląd w Scene: sprawdzaj pozę na miejscu przez Podgląd na liście poz.

- Ikony menu nowych funkcji: oddech, obracanie, wysokość ziemi, tryb zdjęć i inne funkcje mają osobne obrazy dopasowane do istniejących ikon produktu.

### Konfiguracja obracania

W Szczegółach odpowiedniej pozy leżącej wybierz Włącz obracanie i przypisz animację w polu Boczna poza obracania. Zwykłe MotionTime stanie się niedostępne. Włącz też „Funkcje > Funkcje menu > Obróć się” i prześlij awatara. W VRChat wybierz zgodną pozę i Obróć się. Zwolnij blokadę głowy przed użyciem.

Dołączone pozy tej wersji nie zawierają ruchów obracania. Przypisz animację odpowiednią do pozy, której chcesz użyć.

## Obsługiwane presety awatarów i dopasowanie

Dołączono dopasowane presety dla トネール, 狛乃, 士堂 i 真央.

- [トネール](https://booth.pm/ja/items/5236104)
- [狛乃](https://booth.pm/ja/items/5260363)
- [士堂](https://booth.pm/ja/items/8086741)
- [真央](https://booth.pm/ja/items/6846646)

Można używać też innych awatarów. Dopasuj pozy w Dostosowywaniu animacji do budowy ciała i modyfikacji. W Konfiguracji awatara są również Zapobiegaj wyginaniu kolan do tyłu oraz Minimalne zgięcie kolana (stopnie) w Szczegółach.

Automatyczna korekcja kończyn (IK) jest domyślnie włączona. Z 50 dołączonych poz 43 używają IK, a pozostałe 7 dotychczasowych indywidualnych korekcji.

## Instalacja

1. Pobierz pliki ze strony produktu w sklepie, w którym go kupiono.
2. Zaimportuj dołączony „カッコいいポーズツール.unitypackage” do Unity i zarejestruj licencję oraz źródło pakietów.
3. Przez VCC lub ALCOM dodaj Cool Posing Tool i Modular Avatar do używanego projektu Unity. Wspólny Unisaki Posing System i NDMF instalują się jako zależności.
4. Kliknij docelowego awatara prawym przyciskiem w Hierarchy i wybierz „Unisaki Studio > Dodaj Cool Posing”.
5. Wybierz カッコいいポーズ (Cool Posing) dodane do awatara i ustaw potrzebne funkcje i pozy w Inspectorze.
6. Prześlij awatara w zwykły sposób.

Wymagane są Unity 2022.3, VRChat Avatars SDK 3.10.4 lub nowszy, Modular Avatar 1.x w wersji co najmniej 1.15.1 i NDMF 1.x w wersji co najmniej 1.14.0. Zaktualizuj potrzebne pakiety razem w VCC lub ALCOM.

## Aktualizacja ze starszej wersji

Zaktualizuj ten produkt i Unisaki Posing System razem. Ustawienia już umieszczonych narzędzi zostają zachowane. Sprawdź funkcje i zużycie ExpressionParameters w Inspectorze. Jeśli korzystano z budowania wstępnego, naciśnij Aktualizuj budowanie wstępne przed ponownym przesłaniem.

Od v1.1.0 nowe dodawanie korzysta ze zwykłego Prefabu カッコいいポーズ (Cool Posing). Wyłącz niepotrzebne funkcje, aby uzyskać minimalną konfigurację tylko z wyborem poz za 8 bit. Duża liczba poz może wymagać dodatkowych bitów wyboru.

Stary Prefab 8bit pozostaje w Editor/Legacy, aby zachować odwołania istniejących awatarów i presetów. Nie trzeba usuwać ani zastępować istniejącego Prefabu. Wersja 8bit nie jest pokazywana w menu nowego dodawania Unity.

## Gdzie zmieniać ustawienia

| Karta | Możliwości |
| --- | --- |
| Funkcje | Dodawanie menu gry, udogodnienia, ustawienia oddechu oraz sprawdzanie ikon i zużycia ExpressionParameters |
| Pozy | Wybór używanych poz, szczegóły, wyszukiwanie, dodawanie zbiorcze, kolejność, podgląd i dostosowywanie animacji |
| Konfiguracja awatara | Korekcja awatara i kolan, import oryginalnych poz i własnych ruchów, zmiana presetów |

Otwórz ustawienia rozwija szczegółowe pola pod danym punktem. Oddech ustawia się w „Funkcje > Udogodnienia > Animuj oddech”.

Używaj oryginalnych poz stojących, kucających i na brzuchu automatycznie importuje istniejące pozy awatara. Własne ruchy przypisuje się w osobnych ustawieniach importu dla każdego typu: stanie, kucanie (Crouching), leżenie na brzuchu (Prone) i innych.

Presety znajdują się na dole Konfiguracji awatara. Zastosuj ten preset zastępuje bieżące ustawienia poz, więc wcześniej zapisz wykonane korekcje.

### Zużycie poszczególnych funkcji

- Ruch oddechu zużywa 0 bit. Tylko przełącznik zatrzymywania i wznawiania „Funkcje menu > Oddech” używa 1 bit synchronizacji.
- Tryb zdjęć tylko na własnym ekranie to 0 bit. „Udogodnienia > Synchronizuj tryb zdjęć” używa 16 bit. Pokazuj głowę w trybie zdjęć to 0 bit.
- Wysokość stóp i Wysokość ziemi zużywają po 8 bit. Odsunięcie wysokości ziemi od środka przesuwa całe ciało w górę lub w dół, a powrót w okolice 50% kończy działanie.
- Obracanie osobno zużywa 10 bit. Dzieli 1 bit z ograniczeniem deformacji przy obrocie głowy, więc obie funkcje razem nadal zużywają 10 bit.
- Odbicie i Bez gestów zużywają po 1 bit.

Suma w Inspectorze dotyczy narzędzi póz zainstalowanych na awatarze. Nie obejmuje ubrań ani innych funkcji. Wspólne ustawienia kilku narzędzi nie są liczone ponownie.

### Podgląd i edycja poz

Podgląd przy każdej pozie na karcie Pozy pokazuje ją w Scene. Aby poprawić szczegóły, otwórz Dostosowywanie animacji, zmień pozę z podglądem i zapisz.

Uproszczony podgląd nie wykonuje budowania MA ani NDMF. Ubrania i korekcje położenia podłoża dodawane podczas budowania sprawdź także w wyniku budowania przed przesłaniem.

Karta z lupą po lewej wyszukuje nazwy poz. Docelowe miejsce można wybrać w „Szczegóły > Kolejność” lub użyć przycisków w górę i w dół. Kilka animacji dodaje się przeciąganiem do obszaru dodawania albo poleceniem importu klipów wybranych w Project.

Odśwież miniatury poz generuje obrazy po potwierdzeniu. Generuj ikony poz ułatwia rozpoznawanie pozycji w menu gry, ale tworzenie obrazów wydłuża budowanie. Aby ograniczyć rozmiar, wybierz Zmniejsz rozmiar ikon. Android nie generuje ikon poz.

## Podstawowe sterowanie w grze

- Wybierz pozy każdej kategorii w menu Expressions. W VR przejścia między staniem, kucaniem, siedzeniem i leżeniem zależą od wysokości głowy.
- W leżeniu kierunek twarzy przełącza plecy i brzuch. Jeśli wybrano obie pozy, można je zmieniać skokiem; wyłączysz to przez „Funkcje → Udogodnienia → Zmieniaj pozycję leżącą skokiem”. Wysokość zmiany kategorii ustawia się progami w menu ustawień.
- W trybie pulpitu przełączaj pozycję klawiszami C i Z. Jeśli Z nie włącza leżenia, podnieś próg wysokości leżenia w ustawieniach.
- Bez gestów używa kształtu dłoni przypisanego do pozy zamiast gestu palców kontrolera.
- Wysokość stóp reguluje stronę nóg, zachowując położenie głowy. Wysokość ziemi przesuwa całe ciało wraz z głową pionowo. W ustawieniach występują w tej kolejności.
- Ruch do przodu regulatorem Odległość w trybie zdjęć zwraca awatara do ciebie. Kierunek obraca go, a Blokuj stopy można włączyć w odpowiednim momencie. Zakończ zdjęcia zeruje odległość i kierunek oraz zwalnia stopy.
- Oddech działa, gdy jego ruch jest włączony. Siła jest ustawiana w Unity, a w grze zmienia się włączenie.

## Budowanie wstępne i ostrzeżenia

Aktualizuj budowanie wstępne przyspiesza budowanie awatara przez ponowne użycie wygenerowanych danych. Bez budowania wstępnego potrzebne dane powstają podczas zwykłego budowania.

Po zmianie ustawień Sprawdź ustawienia u góry Inspectora oraz znacznik Hierarchy informują o aktualizacji. Wyświetlanie ostrzeżeń znajduje się w ramce Sprawdź ustawienia. Ukrycie widoku nie rozwiązuje problemów konfiguracji ani nie aktualizuje wygenerowanych danych.

## Uwagi dotyczące używania

- Blokada poz podczas pełnego śledzenia ciała nie jest obsługiwana.
- Budowa ciała, ubrania i modyfikacje awatara mogą wymagać dodatkowej korekcji.
- Szczególne warstwy Base i inne mechanizmy zmiany poz nie zawsze łączą się zgodnie z oczekiwaniami. Gdy blokada nie działa, sprawdź „Konfiguracja awatara > Połącz blokady śledzenia z innymi narzędziami”.
- Ruch i obrót trybu zdjęć oraz wysokość ziemi korygują pozy narzędzia oraz standardowe i własne ruchy bez wybranej pozy. Sprawdź ostateczny punkt widzenia i działanie po zastąpieniu ruchów w kliencie VRChat.
- Wyłącz kołysanie w spoczynku VRChat dotyczy standardowego ruchu spoczynkowego. Nie zatrzymuje wszelkiego kołysania wynikającego z innych przyczyn.

## Instrukcja i wsparcie

Górny panel pomocy i historii zmian w Inspectorze otwiera instrukcję, kontakt i historię zmian. Szczegóły wspólnych funkcji są również w Project Unity pod „Packages > Unisaki Posing System > README”.

- [Oficjalna instrukcja](https://docs.unisakistudio.jp/coolposing/manual/)
- [Kontakt ze wsparciem](https://help.unisakistudio.jp/)

Zgłaszając błąd, podaj wersje tego produktu i Unisaki Posing System, Unity, VRChat SDK, Modular Avatar i NDMF, używany awatar, kroki odtworzenia i treść błędu Console.

## Warunki użytkowania

Do produktu dołączono wspólne warunki VN3 dla danych sprzedawanych i udostępnianych przez Unisaki Studio: „ゆにさきスタジオ販売・配布データ利用規約（日本語版）Ver1.0.0.pdf”. Koniecznie przeczytaj je przed użyciem.

Kod źródłowy i zasoby tego repozytorium nie są otwartym oprogramowaniem. Legalnym nabywcom udziela się prawa używania w zakresie dołączonych warunków.
