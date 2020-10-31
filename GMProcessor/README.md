# GMProcessor

GMProcessor to biblioteka klas (ClassLibrary .NET Core) zaiwerająca implementację metod do obsługi wydarzeń w aplikacji [GeneralManagementUI](https://github.com/GxOyAzT/RetailManagementSystem/tree/main/GeneralManagementUI).

Biblioteka składa się z implementacji poszczególnych funkcjonalności i ich abstrakcji. Każda funkcjonalność posiada swoją klasę w której znajduje się od jednej do kilku metod przetwarzających dane. Każda klasa posiada swój interfejs, dzięki temu w najwyższym module (GeneralManagementUI) za pomocą AutoFac mogę w prosty sposób odwrócić zależności.

Biblioteka pozwoliła również oddzielić warstwę komunikacji z użytkownikiem od warstwy walidacji danych oraz interakcji z bazą danych

## Użyte wzorce projektowe:
- Dependency Inversion
- Single Responsibility
