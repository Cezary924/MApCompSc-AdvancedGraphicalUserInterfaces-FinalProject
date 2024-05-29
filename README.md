# Projekt zaliczeniowy - Zaawansowane Interfejsy Graficzne

Tytul: _Gra 'Galaktyczny Biznes'_

Autor: _Cezary924_

Jezyk: _C#, WPF_

Rok: _2023/2024_


## Zasady/przebieg gry


Gracz wciela się w postać biznesmena galaktycznego. Podróżując przez galaktykę 
odwiedza różne układy planetarne i inne tajemnicze zakątki wszechświata. 
Gracz może zająć niezamieszkane/nieprzejęte planety poprzez wybudowanie na 
nich portu kosmicznego. Na planetach można także wybudować (o ile gracz jest 
właścicielem planety) posterunek (który w kolejnych turach można rozbudowywać 
do: habitatów mieszkalnych, kolonii, hotelu galaktycznego oraz, jeśli gracz 
jest właścicielem wszystkich planet w systemie, sieci hoteli planetarnych), 
kopalnie (można je rozbudowywać w kolejnych turach do kopalni 2-go i 3-go 
stopnia) oraz farmy żywności (można je rozbudowywać do 5 kolejnych poziomów). 
Dodatkowo, jeśli gracz jest właścicielem wszystkich planet w danym systemie, 
może on wybudować asteroidalną kopalnię, a także stocznię galaktyczną.
W trakcie gry gracz posługuje się walutą o nazwie kredyt galaktyczny (KG). 
Gracz ma za zadanie tak poprowadzić grę, aby przeciwnik stracił wszystkie 
posiadane w danym momencie oszczędności (stan konta: 0 KG). Dodatkowo, gracz 
może wygrać z przeciwnikiem, jeśli jego cały majątek (stan konta + wartości 
posiadanych nieruchomości) będzie stanowił ponad 50% wartości wszystkich 
możliwych do wybudowania budynków (suma wartości z każdej planety każdego 
systemu).


## Struktura kosmosu


Poza różnymi systemami planetarnymi, w kosmosie znajduje się również obszar 
Szansa. Wlatując w ten obszar możemy wylosować jedną spośród następujących 
kart: atak piratów, karta obrony przed piratami, bilet galaktyczny, 
imperator zarządził pobranie jednorazowego podatku od nieruchomości (20% 
wartości posiadanych nieruchomości), wygrana w galaktycznej loterii, awaria 
silniku statku (zapłata za holowanie), awaria w stoczni galaktycznej (jeśli 
gracz takową posiada). Gracz może posiadać tylko jedną kartę obrony przed 
piratami oraz tylko jeden bilet galaktyczny. W galaktyce można napotkać 
piratów - pole Piraci powoduje utratę 2 kolejek, jednak gracz ma możliwość 
zapłaty okupu lub wykorzystania karty obrony przed piratami o ile jest 
w posiadaniu tej karty (wówczas gracz nie traci żadnej kolejki). Galaktyka 
posiada również rozbudowaną sieć kolei galaktycznych. Jeśli gracz posiada 
bilet galaktyczny może wybrać dowolny przystanek kolei - Dworzec - i do niego 
się przenieść.


## Interfejs


Interfejs graficzny aplikacji podzielony jest na 9 części:
1. Gra (prawy górny kafelek) - zawiera "menu gry", które pozwala na 
uruchomienie gry i wybranie jej trybu.
2. Statystyki - zawiera informacje o graczach w grze (stany konta, listy 
posiadanych budynków, listy posiadanych kart).
3. Tura - zawiera numer obecnej tury i przycisk przejścia dalej.
4. Ruch - zawiera informacje o tym, który gracz wykonuje obecnie ruch - czyli 
którego gracza dotyczą informacje widoczne na środkowych/dolnych kafelkach.
5. Obecne pole gry (środkowy kafelek) - zawiera kontrolki dopasowane do 
miejsca, w którym gracz obecnie się znajduje; pozwala graczom na wykonanie 
ruchu w swojej turze - najważniejsza część interfejsu dla przebiegu gry.
6. Informacje - zawiera (w razie potrzeby) krótką informację o przebiegu gry.
7. Rozkład układu - zawiera informację o strukturze (planetach) układu, na 
którym znajduje się obecnie "główny" gracz (ten, który ma wykonać ruch).
8. Plansza - zawiera tabelkę, której pierwszy wiersz składa się z kolejnych 
nazw miejsc galaktyki (9 różnych pól), a drugi wiersz - przedstawia obecną 
lokalizację graczy (plansza zapętla się - po ostatnim polu znajduje się 
ponownie pierwsze).
9. Kostki (lewy dolny kafelek) - zawiera informację o wylosowanych wartościach 
(wartość 1. kostki odpowiada liczbie pól, jakie gracz pokonał od poprzedniego 
ruchu; wartość 2. kostki dotyczy numeru planety danego systemu, w innych 
przypadkach jej wartość nie jest przedstawiana).
W poszczególnych turach nie każda opcja musi być dostępna/widoczna 
(z racji na np. niski stan konta gracza, bądź gdy dana planeta należy do 
innego - wirtualnego - gracza). Interfejs ma pozwalać na wykonanie tylko 
możliwych przez gracza ruchów.


## Dodatkowe informacje o grze


Gra posiada dwa tryby gry: gracz vs gracz (gracz-człowiek przeciwko drugiemu 
graczowi-człowiekowi), gracz vs komputer (gracz-człowiek przeciwko symulowanym 
losowym ruchom gracza-komputera).
Gracz może wykonać tylko jedną operację w czasie swojej tury.
Koszt wykonania poszczególnych operacji przez gracza przedstawiony jest obok 
ich nazw (w walucie KG).
Na start gracze otrzymują 350 KG.
Co 5 tur gracze otrzymują 100 KG oraz zarobek z posiadanych nieruchomości 
(10% ich wartości).
Wysokość opłaty za postój na planecie przeciwnika to: 25 KG + 10% wartości 
nieruchomości na tej planecie.
Gracz, jeśli znajduje się na swojej planecie, to poza możliwością ulepszenia 
jej nieruchomości ma również możliwość oddania planety pod zastaw. W efekcie, 
gracz otrzymuje 50% wartości jej nieruchomości, inni gracze przestają płacić 
mu opłatę za postój, podatek od jej nieruchomości nie jest pobierany, zarobek 
nie jest przyznawany. Planetę właściciel może odkupić - po ponownym pojawieniu 
się na planecie i przeznaczeniu na ten cel tej samej kwoty, którą otrzymał za 
nią wcześniej.
W każdej turze odległość ruchu do przodu gracza zależy od wylosowanej wartości - 
od 1 do 3 (wirtualna "kostka").
Dodatkowo, jeśli gracz zatrzyma się na terenie jakiegoś układu planetarnego, 
to (podobnie jak wyżej) losowane jest, na której planecie systemu wyląduje.
Większość struktury gry oraz jej działanie (niewidoczne dla użytkownika) 
oparte są na metodach klasy Game należącej do specjalnie stworzonej biblioteki 
(tzw. silnika) o nazwie GameEngine.