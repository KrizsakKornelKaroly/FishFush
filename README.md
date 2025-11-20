# FishFush
## Projekt leírása
Az FishFush az egy C#-ban írt fikcionális halnyilvántartó konzolos applikációja, amelyben a felhasználó képes felvenni halakat és kilistázni azokat.
### Osztályaink
- Fish (`virtual`)
- Herbivore
- Carnivore
- Ornamental (`abstract`)
- Freshwater
- Sea
### Metódusok és tulajdonságok
- Fish
  - _toString()_
  - Color (string)
  - Length (int)
  - Name (string)
  - Lifespan (int)
- Herbivore
  - _override toString(+Herbivore)_
  - abstract _herbivoreDesc()_
- Carnivore
  - _override toString(+Carnivore)_
  - abstract _carnivoreDesc()_
- Ornamental
  - NeededSpace (int)
  - Price (int)
- Freshwater
  - _isMigrant()_
  - ToleranceToSalinity (int) (Só-tűrés szintje (0–10))
- Sea
  - _isMigrant()_
  - SalinityLevel (double) (Optimális sótartalom (pl. 35‰).)
