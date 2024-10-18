# Övning Klubb-Epidemin
* Skapa ett objekt: Person, med följande egenskaper
    * Smittad (bool)
    * SmittadNär (int, personen ska bli frisk igen efter 5 timmar.)
    * Immun (bool, en smittad person som blivit frisk kan inte bli sjuk igen)
* Skapa en lista: club, där du stoppar in 20 personer.
* Ange att EN person är sjuk.
* Loopa igenom listan och anta att varje sjuk person smittar 1(en) annan person per timme.
* Första timmen smittar alltså den enda sjuka personen en annan person.
* Andra timmen smittar dessa två personer ytterligare varsin person
* Tredje timmen smittar alla fyra ytterligare fyra personer…osv
* När 5 timmar gått blir första personen frisk, och smittar ingen längre (och är immun), men de andra fortsätter smitta…
* Stega fram timmarna med en tangenttryckning, en timme per tryck.
* Visa i konsollen vilka som är smittade, och hur många som är immuna.
* Visa också hur många timmar som går.
* Hur många timmar tar det innan alla är immuna?
