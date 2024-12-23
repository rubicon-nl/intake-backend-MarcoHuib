# intake-opdracht

## Context
Je werkt voor een consultancy bedrijf (Rubicon) dat gespecialiseerd is in Azure development, Azure migraties en AI.  
Rubicon bezig met een nieuwe feature voor de RubiCrew in hun web applicatie. Met deze nieuwe feature hoopt Rubicon ervoor te zorgen dat developers vaker buiten komen,  Aangezien ze veel binnen zitten. De web applicatie is een SPA waarbij de backend met Azure Functions is opgezet.  
Een collega van jou is begonnen aan de opzet van de backend in Azure, maar is helaas ziek geworden en zal, gezien de krappe deadline het project niet kunnen afmaken.  Jou is gevraagd om het project over te nemen het de backend af te maken.

## Opdrachtomschrijving
Jouw taak is om de weather forecasting service verder te ontwikkelen. Dit omvat het ophalen van weersvoorspellingen, berekenen van temperatuurverschillen, en het bepalen van de optimale buitenwerk dag. De bepaling van deze dag wordt aan de hand van Temperatuur, weertype en wind gedaan. Aangezien de bepaling nog in een ontwikkelstadium bevind moeten deze parameters gemakkelijk aan te passen zijn.

Jou collega heeft al een Solution gemaakt met daarin al een Azure Function waarop jij verder kan bouwen. Voor het ophalen van de benodigde weersvoorspellingen kan de [OpenWeathermap API](https://openweathermap.org/forecast5) gebruikt worden. Voor het aanroepen van deze api heeft hij al een library gerealiseerd die via [Nuget](https://www.nuget.org/packages/Rubicon-nl.openweather) aangeboden wordt.

## Features
De te realiseren backend moet de volgende features bevatten.
- Haald weergegevens op voor de komende 5 dagen voor een opgegeven locatie.
- Bereken het temperatuurverschil tussen de verschillende dagen.
- Bepaal de ideale dag om buiten te werken op basis van temperatuur, neerslag en wind (Bepaal deze parameters zelf o.b.v. wat jij prettig vind om buiten te werken).
- De parameters moeten gemakkelijk aan te passen zijn.
- Toon de berekende temperatuurverschillen per dag, de dag toont altijd het verschil ten opzichte van de voorgaande dag.
- Toon de beste dag om buiten te werken met een duidelijke uitleg waarom deze dag is geselecteerd.

## Requirements
Houdt de applicatie simpel, het gaat primair om de code niet om een fancy user interface.  Gebruik bijv. tools als Postman voor het testen van je Web API.  
Borg je oplossing met Unit Tests, bepaal zelf een relevante code coverage. Je mag een framework naar keus gebruiken, maar ook hier geldt: houdt het clean en simpel.   

Gebruik een recente versie van Visual Studio of visual studio code voor het uitwerken van je opdracht.
De oplossing dient uiterlijk 4 dagen na ontvangst van deze opdracht ingeleverd te zijn.
Programmeer in het Engels (methods, classes, properties, etc.) en gebruik duidelijke naamgeving.
Voorzie je publieke methoden en classes van een commentaar. Commentaar mag in het Nederlands, maar bij voorkeur in het Engels.
Commit je code in je repositorie en vraag een Pull Request aan naar de main repo wanneer je klaar ben.

<span style="color:red;">**Let op: de code dient als minimum te compileren en te runnen! Indien dit niet het geval is wordt de uitwerking niet verder in behandeling genomen en de opdracht afgekeurd.**</span>