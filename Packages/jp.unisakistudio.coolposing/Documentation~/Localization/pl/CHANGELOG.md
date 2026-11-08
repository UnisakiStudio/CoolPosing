# Historia zmian

## [1.2.0] - Niewydane

### Dodano

- Wyświetlanie Inspectora, operacji edycji, okien instalacji, standardowych nazw poz i generowanego menu VRChat w 30 językach.
- Połączono wybór języka Inspectora i menu gry. Domyślnie używany jest język komputera, a ostatni wybór dotyczy także innych projektów tego samego użytkownika systemu.
- README, historia zmian i instrukcja offline otwierają się w wybranym języku.
- Przygotowano nazwy wszystkich 128 standardowych poz i opisy funkcji zgodnie z dotychczasową terminologią.

### Zgodność

- Zachowywane są istniejące ustawienia awatara, własne nazwy, odwołania do zasobów, identyfikatory parametrów i sposób przechowywania licencji.

## [1.1.0] - 2026-11-07

- W 43 z 50 dołączonych poz kończyny są automatycznie dopasowywane do budowy ciała przez IK. Pozostałe 7 używa dotychczasowych indywidualnych korekcji.
- Tryb zdjęć pozwala zmieniać pozycję i kierunek awatara. Można wybrać synchronizację pozycji i kierunku oraz widoczność własnej głowy podczas zdjęć.
- Wysokość ziemi przesuwa całe ciało do 3m w górę lub w dół, uzupełniając wysokość stóp.
- Dodano oddech, wyłączanie standardowego kołysania w spoczynku i ograniczanie deformacji pozy od kierunku głowy.
- Używane funkcje i zużycie parametrów są widoczne w Inspectorze. Dodano wyszukiwanie poz, dodawanie zbiorcze, sortowanie i uproszczony podgląd w Scene.
- Przyspieszono zmiany między staniem, kucaniem i siedzeniem w trybie pulpitu.
- Poprawiono ostrzeżenia po zmianie ustawień budowania wstępnego, obciążenie przewijaniem Inspectora i długie zatrzymania przy porządkowaniu zasobów.
- Dodano obsługę Unisaki Posing System 3.1.0.
- Ruchy obracania dla dołączonych poz nie są zawarte.

## [1.1.0-beta.2] - Otwarta beta (2026-11-05)

- Skonfigurowano automatyczną korekcję kończyn (IK) dla 43 z 50 dołączonych poz. Pozostałe 7 używa dotychczasowych indywidualnych korekcji.
- Dodano obsługę wspólnego pakietu 3.1.0-beta.2. Pozy tej wersji nie zawierają dołączonych ruchów obracania.

## [1.1.0-beta.1] - Otwarta beta (2026-11-04)

- Dodano obsługę Unisaki Posing System 3.1.0-beta.1.
- Zwykłe przełączanie poz w trybie pulpitu używa jednego obliczenia. Działa przy zwykłym budowaniu i budowaniu wstępnym; VR i szczególne warunki zachowują dotychczasową ścieżkę.
- Wyniki budowania wstępnego z alpha.3 i starszych wersji są rozpoznawane jako wymagające aktualizacji.
- Punkt widzenia pozostaje zachowany przy zmianie wysokości ziemi podczas zdjęć, a po zakończeniu wraca do ostatniej wysokości ziemi.
- Uwzględniono poprawki automatycznego importu, dostosowania importowanych ruchów i zarządzania generowanymi Controllerami do alpha.3 włącznie.

## [1.1.0-alpha.1] - Przed publikacją

### Dodano

- Dodano obracanie i odpowiednie ustawienia animacji dla każdej pozy.
- Dodano osobne ikony menu oddechu, obracania, wysokości ziemi, trybu zdjęć, odległości, kierunku i zakończenia zdjęć.
- Dodano tryb zdjęć do przesuwania do przodu i obracania.
- Dodano synchronizację trybu zdjęć: tylko lokalnie — 0 bit, synchronizacja — 16 bit.
- Dodano zachowanie widoczności własnej głowy w trybie zdjęć.
- Dodano Wysokość ziemi, podnoszącą całe ciało wraz z głową.
- Dodano ruch i siłę oddechu oraz przełącznik w grze.
- Dodano wyłączanie standardowego kołysania VRChat.
- Dodano ograniczanie deformacji pozy od kierunku głowy.
- Dodano zapobieganie wyginaniu kolan do tyłu i minimalny kąt zgięcia.
- Dodano przełączniki funkcji i widok zużycia ExpressionParameters.
- Dodano uproszczony podgląd w Scene, wyszukiwanie poz, dodawanie zbiorcze i wybór docelowej kolejności.
- Dodano historię zmian w Inspectorze.

### Zmieniono

- Inspector podzielono na 3 karty: Funkcje, Pozy i Konfiguracja awatara.
- Uporządkowano miejsca szczegółów oddechu, importu własnych ruchów i presetów.
- Ograniczono powielanie animacji tworzonych do regulacji wysokości stóp.
- Dodano potwierdzenie aktualizacji obrazów poz i zebrano ustawienia ostrzeżeń w Sprawdź ustawienia.
- Usunięto menu nowego dodawania wersji 8bit, zastępując je wyborem funkcji zwykłego Prefabu. Istniejące odwołania pozostają.
- Dodano obsługę Unisaki Posing System 3.1.0-alpha.1. Minimalną wersję VRChat Avatars SDK zmieniono na 3.10.4.

### Naprawiono

- Naprawiono przechodzenie wpisywanej nazwy do innej pozy oraz zamykanie szczegółów przy sortowaniu.
- Naprawiono nakładanie podglądów, przesunięcia rozmieszczenia i błędy niektórych awatarów.
- Naprawiono odświeżanie ostrzeżeń i stanu budowania wstępnego po zmianach ustawień oraz niektóre błędy budowania.

## [1.0.0] - 2026-09-06

- Oficjalne wydanie
- Dodano presety awatarów (トネール, 狛乃, 士堂, 真央)

## [1.0.0-alpha.1] - 2026-09-06

- Wydanie
