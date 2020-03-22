# Konzeptionierung / Vision Architecture

Die Idee bzw. die Vision hinter [DEEPER] ist vom Umfang deutlich größer und mächtiger als das was sich in 48h letztlich umsetzen lässt.
Aus diesem Grund beginnen wir hier mit einem Kurzüberblick über die Vision Architecture.

Im folgenden werden die einzelnen Bausteine des DEEPER-Systems vorgestellt, die in unseren Köpfen sich ausgemalt haben.

<p align="center">
<img src="images/Architecture_VisionArchitecture.PNG" height="400">
</p>
Bild: Vision Architecture (eigene Grafik)


## Architektur-Muster
Unser Ziel war und ist es ein System zu entwerfen, welches auf eine globale Anwendung skaliert werden kann.
Die Zugriffshäufigkeit mit 1x am Tag pro Nutzer, zeitlich verteilt über den Tag und die verschiedenen Zeitzonen der Welt, erwarten wir keine großen Datenraten, die von Außen in das System eingespielt werden.
Innerhalb des Systems, durch unter Umständen notwendigen wiederkehrenden Berechnungen (falls bspw. einer positiv markiert wurde, hätte dies rückwirkend 14 Tage Einfluss auf bereits berechnete Werte), können zu einem erhöhten Traffic innerhalb des Systems führen. 

Auf Grund der guten Eigenschaften von Skalierbarkeit, Wartbarkeit und Anpassbarkeit, sowie den verbesserten Load-Balancing Eigenschaften im System-Inneren, ist die Entscheidung auf die Anwendung einer Micro-Service-Architecture gefallen.
[Quelle: Richards M. (2015), Microservices vs. Service-oriented Architecture, O'Reilly Media]

Das Prinzip des Share-as-less-as-possible oder gar Share-nothing Prinzip ermöglicht es ganze Dienste-Einheiten ohne große Aufwände zu duplizieren, hinzuzufügen oder zu entfernen. 
Für ein System mit globaler Skalierung bieten sich diese Eigenschaften durchaus an.

Somit viel die Entscheidung nach kurzer Recherche für einen Architekturansatz auf einen MSA-Ansatz.



## System-Komponenten

### User-Input-Services
Als mögliche Eingabe-Quelle für Symptom- und Geo-Informationen gibt es unterschiedliche Möglichkeiten. Hierbei haben wir bspw. mal die drei - Telefon, Bot, Mobile App - aufgegriffen.
Während eine Mobile App, gerade das Geo-Tracking besser unterstützen, als ein Telefon oder Bot-System, wäre es dennoch über andere Möglichkeiten und Mechanismen durchaus in Ansätzen realisierbar. 

Zusammenfassend kommen den User-Input-Services die Rolle der Dateneingabe zu. 
Auf Grund einer offenen REST-Schnittstelle, wäre es aber auch denkbar andere Datenquellen in das System einzubinden (bspw. Datensysteme, Algorithmen, Lösungen anderer Teams).


### Medical-User-UI-Service

Dieser Service ermöglicht medizinischem Fachpersonal über einen authentifizierten Kanal positive Befunde an die Daten des Nutzers hinzuzufügen bzw. auch wieder zu entfernen.
Durch diese Befund-Bestätigung wird die Qualität der Symptom-Daten erhöht und gesichert. 
Um hier keine falschen Inhalte zu generieren, ist dieser Zugang nur durch medizinisches Fachpersonal möglich.

### Short-Term-Data-Persistance

Dieser Datenbank-Dienst speichert die Daten die für die Analysen über den für das Krankheitsbild notwendigen Zeitraum in der sich die Symptome ausprägen.
Es ist quasi die Daten im System-Inneren der Anwendung. 

### Long-Term-Data-Persistance

Dieser Datenbank-Dienst speichert die Daten weg, die für die Analysen im System-Inneren nicht mehr benötigt werden.
Ziel dieses Systems ist die Langzeit-Bereitstellung der erfassten Daten für Ausbildung, Forschung und Entwicklung. 
Hier wäre das Wunsch-Ziel eine Open-Data-Initiative zu etablieren.

Anwendungsbereich für die Open-Data Inhalte wäre die Verbesserung des Systems durch historische Daten, die als Trainingsdaten genutzt werden können.
Hierbei spielt auch die Wichtigkeit des medizinischen Befunds wieder, der den Symptomatischen Verlauf als positiv markiert. 

Des Weiteren sind Trainingsdaten für Simulationsmodelle denkbar.

### Finding-Response-Service

In diesem System wird quasi die Interpretation der Analysen durchgeführt. 
Hierbei gibt es unterschiedliche Schweregrade der Wahrscheinlichkeitsfaktoren. 
Diese Faktoren variieren basierend auf den Basis-Medizin-Informationen (bei Personen der Gefahrengruppe sind die Thresholds generell niedriger anzusätzen) die bspw. über die Covid-App der Charité Berlin ermittelt werden.

Wie die Public Research Gruppe unseres Teams aufgezeigt hat, ist es notwendig, einen ausgleichenden Mehrwert für die herausgabe der Daten zu bieten.
Aufbereitete Informationen, die zum derzeitigen Wahrscheinlichkeitsfaktor des Nutzers passen, werden durch diesen eher Content getriebenen Dienst zusammengestellt, aufbereitet und bereitgestellt. 
Hier wird der eigentliche Mehrwert für den Nutzer generiert. 


### Analysing Services

Vorab, inhaltliche Beschreibungen der zu Grunde liegenden Modelle, Berechnungen und wissenschaftlichen Quellen, sind dem Scientific Research Team und deren wissenschaftliche Ausarbeitung zu entnehmen.

#### Propability-Symptome-Analysis

Dieser Analyse-Dienst nutzt die täglichen Symptome und berechnet auf Basis eines Wahrscheinlichkeitsmodells einen Wahrscheinlichkeitsfaktor für das Krankheitsbild.
Die Faktoren des Modells basieren auf einer gewichteten Bewertung von Symptomen nach derzeit aktuellen wissenschaftlichen Inhalten.

#### Propability-Gradient-Analysis

Dieser Analyse-Dienst untersucht den Verlauf des Wahrscheinlichkeitswerts eines Tages aus dem Zeitraum der verganenen X Tage (Covid-19 wären dies 14 Tage).
Aus diesem Grund sind die Eingaben meist auch in einer sehr feinen Auflösung, dass die Eingabe durchaus eine Trendentwicklung ermöglicht.

Der Einfluss dieser Analyse auf den Wahrscheinlichkeitswert wäre eine Erhöhung, wenn in der Vergangenheit bereits ein ansteigender Trend zu verzeichnen war.
Im Gegenzug wird der Faktor reduziert, wenn man auf dem Weg der Besserung ist.

#### Geo-Tracking-Analysis

Dieser Teil erstellt quasi Heatmaps über die Wahrscheinlichkeitsfaktoren aller Nutzer einer Region. Der Wahrscheinlichkeitsfaktor wird entsprechend erhöht, wenn es mehr Nutzer mit einem bereits erhöhten Wert in der eigenen Umgebung gibt. Er wird nicht erhöht, wenn es keinen signifikanten Anteil an erhöhten Wahrscheinlichkeiten bei anderen Nutzern gibt. Er wird aber nicht reduziert. 


### Knowledge-Service

Das System soll bei weitem nicht nur Symptome und das Krankheitsbild von Covid-19 beinhalten.
Andere Symptome und Krankheitsbilder können in allgemeinen Krankheitsphasen durch aus in einer sehr ausführlichen Breite betrieben werden.
In Krisenphasen, wie wir sie derzeit erleben, können einige Symptome rausgenommen werden und einige Krankheitsbilder nicht analysiert werden.
Somit bietet das System die Möglichkeit seitens der medizinischen Voreinschätzung konkrete auf aktuelle Gegebenheiten zu reagieren.
Der Knowledge-Service ist der zentrale Knoten in dem alle Informationen, Parameter und Berechnungsfunktionen ausgelagert sind, die für die Analysen benötigt werden.

Der Knowledge-Service wird nochmal in einem eigenen Spezial-Kapitel betrachtet.


### Zusammenfassung für die Architektur

Alle Komponenten sind sehr kleinteilig angelegt und nach deren Funktionsschwerpunkt separiert (Separation of Concerns).
Zwischen allen Komponenten wurden übergreifende Datenmodelle und Schnittstellen definiert. Jede Komponente entwickelt demnach gegen diese Schnittstellen- und Datenmodelle.
Somit wird Austauschbarkeit, Wartbarkeit und Skalierbarkeit sichergestellt. 

## Prototyp Solution / Implementation

### Umfang des Prototyps

Die prototypische Lösung hat das Ziel das Handling in Ansätzen und vorallem die wissenschaftlichen Analysen in einem realen Umfeld erlebbar zu machen und experimentieren zu können.
Aus dem Grund war nicht das Ziel das gesamte Vision Architecture System zu realisieren.

Folgende Punkte wurden in dem Prototyp realisiert:

[x] User-UI-Dienst
[x] Short-Term-Data-Persistance
[x] Propability-Symptome-Analysis
[x] Finding-Response-Service
[x] Knowledge-Service

folgende Punkte wurden nicht realisiert:

[] Medical-UI-Dienst
[] Long-Term-Data-Persistance
[] Propability-Gradient-Analysis
[] Geo-Tracking-Analysis
[] User-Telefon-Dienst
[] User-Bot-Dienst
[] alle anderen Anwendungsfälle die in der Vision dargestellt wurden

## Technische Details

Das Backend ist in AWS (Amazon-Web-Services) Beanstalk Umgebung gehostet.
Laufzeitsystem ist ein Windows Server 2012 mit .NET Core 2.1

Demnach wurde mit Hilfe von Visual Studio 2019, Visual Studio Code und der Sprache C# programmiert.

Das Backend-System ist auch nicht in der vorgestellten Micro-Service-Architektur realisiert worden.
Hintergrund dieser Entscheidung für den Hackathon ist der hohe Aufwand zur Konfiguratioon der Netzwerk-Infrastruktur für ein solches verteiltes System.
Alle Dienste Komponenten sind als Background-Worker in einer monolithischen Anwendung realisiert. 
Die Datenfluss-Mechanismen, wie bspw. das Pull-Prinzip der Analyse-Dienste, wurde mit Event-Aggregator-Ansatz entsprechend realisiert. 

## Architektur-Schema

<p align="center">
<img src="images/Architecture_PrototypeArchitecture.PNG" height="400">
</p>
Bild: Vision Architecture (eigene Grafik)


## Vorgehensweise

Das Gesamtsystem wurde Freitagabend nach Beginn der Hackathon-Phase mit Hilfe der Web-Anwendung Miro entworfen. (siehe Grafiken)

Die Aufteilung im Entwickler-Team wurde nach agilen Methoden in einem Kanbanboard gelöst.

<p align="center">
<img src="images/Architecture_KanbanBoard.PNG" height="400">
</p>
Bild: Auszug aus dem Kanban-Board am Ende des Hackathons (eigene Grafik)

In grün sind die realisierten Teilsysteme dargestellt, in lila die entsprechenden Bearbeiter.

