# Disease Pattern Early Recognition in Global Distribution!
\#WirVsVirus

<p align="center">
<img src="documentation/images/KeyVisual.jpg" height="400">
</p>

# Problembeschreibung
Viruserkrankungen sind Teil von unserem Leben. Jedes Jahr treten - vor allem in den Wintermonaten - 
"Erkrankungen durch saisonal zirkulierende, humane Influenzaviren"[1] auf. Dies erfolgt durch die Mutation der Viren, welche aber prognostiziert und daher gut therapiert werden können. 

Im Vergleich dazu gibt es Viren, "gegen [die] es in der Bevölkerung keine oder nur in einem kleinen Anteil der Bevölkerung eine vorbestehende Immunität gibt, [die] humanpathogen [sind] und [die] sich leicht von Mensch zu Mensch [verbreiten]" [1]. Der SARS-CoV-2 zählt zu diesen Viren. 

Durch eine immer engere Vernetzung der Menschen sowohl im Gesellschaftlichem, wie im Wirtschaftlichem als auch länder- und kontinentenübergreifend, ist die Ausbreitungsgeschwindigkeit für solche Viren deutlich gestiegen. Kommen dann noch lange Inkubationszeiten und unterschiedliche Krankheitsverläufe, wie bei Covid-19 dazu, wird auch die Ermittlung von Infektionsketten sowie die Vorhersage zukünftiger Hotspots von Infizierten erschwert. Aus diesen Gründen kann es schnell von einer Epidemie zu einer weltweiten Pandemie kommen. Dies steigert die Angst in der Bevölkerung, sich selber zu infiziert. 

Zusammengefasst sind die Hauptprobleme:

1. Eigenschaften der Viren zu Beginn des Auftretens unbekannt,
2. Krankheitsverlauf unbekannt und unterschiedlich,
3. Keine passende Therapie,
4. Kein Impfstoff zur Verfügung,
5. Ausbreitungsgeschwindigkeit sehr hoch,
6. Ermittlung von Infizierten und Infektionsketten schwierig,
7. Vorhersage von entstehenden Hotspots von Infizierten nicht gegeben
8. Steigende Angst in der Bevölkerung

Dies hat unter anderem zur Folge, dass Ärzte häufiger aufgesucht werden, eine hohe Dunkelziffer von Infizierten vorliegt und das gerade über milde Verläufe wenig bis keine Kenntnisse möglich sind. Dies zusammen hat dann meistens zur Folge, dass vor allem die öffentlichen und medizinischen Gesundheitssysteme an ihre Kapazitäten stoßen. Um dem entgegen zu wirken, müssen Lösungen für die verschiedenen Probleme entwickelt werden. 

[1] Nationaler Pandemieplan Teil II. "Wissenschaftliche Grundlagen." Robert Koch-Institut, März 2017.

# Lösung
Im Rahmen des Hackathons wurde eine Lösung entwickelt, die die Probleme 2, 6, 7 und 8 adressiert. Hierfür wurde eine App entwickelt, die 

- Daten, wie Ausprägung der Symptome oder Positionsdaten, vom Nutzer entgegen nimmt,
- diese mit [TODO: Wording] Algorithmen verarbeitet und
- die Ergebnisse dem Nutzer in einfacher verständlicher Weise anzeigt sowie
- Schnittstellen für andere Datennutzer (z. B. Regierung, medizinische Forschung) zur Verfügung stellt.

Zur Erstellung der Lösung wurde methodisch vorgegangen. Es wurden zunächst Personas für die Nutzer entwickelt und Umfragen zum Funktionsumfang und Nutzerverhalten durchgeführt. Basierend auf den Ergebnissen wurden die Herausforderungen an diese App ermittelt, die sich in drei Hauptkategorien unterteilen lassen: Akzeptanz in der Gesellschaft, Nutzung der App und technische Umsetzung. Zu jeder der Hauptkategorien haben wir Fragen ermittelt, die beantwortet werden müssen. In einem nächsten Schritt haben wir eine Analyse bestehender Lösungen durchgeführt und ermittelt, dass keiner der Lösungen, die Herausforderungen voll umfänglich erfüllt. Aus diesem Grund haben wir ein eigenes Konzept einer App entwickelt und für dieses zwei prototypische Umsetzung in Form eines Klick-Dummys sowie einer Implementierung entwickelt, auf denen im Anschluss weiter aufgebaut werden kann.

# Ergebnisse

[Personas](documentation/Personas.md)

[Umfragen](documentation/Umfragen.md)

[Analyse existierender Lösungen](documentation/Wettbewerbsanalyse.md)

[Lösungskonzept](documentation/Konzept.md)

[Klick-Dummy](documentation/Klick-Dummy.md)

[Implementierung](documentation/Implementierung.md)


# Team Introduction

Wir sind ein bund gemischtes Team, zu Beginn alles Mitglieder/Freunde des Netzwerks der Studenten und Jungingenieure des VDI (Verein Deutscher Ingenieure).
Im weiteren Verlauf des Hackathons haben wir uns mit Experteninnen und Experten verschiedener Fachrichtungen ausgetauscht und ergänzt. 

Unser Team:

**System Development / Hacking** Architecture / Development of a scalable micro-service oriented architecture 

- Andreas Stutz (Architecture, Deployment, )
- Benedikt Geib (REST-API / Mobile App)
- Janik Ritz (Data Persistance)
- Melanie Wassmer (Mobile App)
- Philipp Gesner (Data Analysis)
- Marwin Madsen (Mobile App)

**Scientific Research**
- Kathrin Krote
- Johanna Hoppe 
- Charlotte Maschke


**Public Research**
- Luisa Miny (User Experience)
- Torben Deppe (Research Communication)
- David Seck (???)
- Vincent Laux (MockUp / Usability)
- Riadh Dhaoui (Video Design)
- Jonas Thees (???)


# List of Repositories

**Cloud Application**
https://github.com/stan1025/WirVsVirus

Special Thanks to Amazon Web Service especially to Pawel Warmuth for supporting with a billing voucher as well as the great support!

**Mobile Application**
https://github.com/stan1025/WirVsVirus_App





Follow the link and find more information about our idea: ["Disease-pattern-early-recognition-in-global-distribution"](https://devpost.com/software/disease-pattern-early-recognition-in-global-distribution#updates)











# Topic Introduction

:arrow_forward: ## ID:
01_708_DiseasePatternEarlyRecognitionInGlobalDistribution

:arrow_forward: ## Title: 
Disease Pattern Early Recognition / Krankheitsbild-Früherkennung 

:arrow_forward: ## Challenge:

Die Herausforderung liegt hierbei, dass meistens erst Mediziner das Krankheitsbild aus den symptomatischen Anzeichen ihrer Patienten erkennen. 
Hierbei handelt es sich um eine 1:1 Behandlung, wobei eine Vielzahl von Patienten auf vergleichsweise wenige Fachärzte kommen. 
Wir sehen, dass weltweit die Gesundheitssysteme mehr oder weniger Probleme bekommen, die Untersuchung durchzuführen und über eine Testdurchführung entscheiden müssen. 
Auf Basis digitaler Technologien, einer Informationsaggregation aus Symptomen und Positionsdaten, kann mittels Methoden der KI eine Wahrscheinlichkeit für die Infektion mit SARS-CoV-2 (oder auch unterschiedliche Krankheitsbilder) ermittelt werden. 
Auf Basis dieser Bewertung wird eine Vorauswahl getroffen. Nur Patienten mit einer hohen Wahrscheinlichkeit wird der Besuch eines Arztes angeraten. 

:arrow_forward: ## Appell:
Wir brauchen eine digitale Lösung, die sowohl jung als auch alt berücksichtigt. 
Diese Lösung nutzt KI-Methoden zur Früherkennung von Krankheitsbildern auf Basis einer Symptom-Erfassung und Bewertung. 
Dies entlastet unsere medizinischen Kapazitäten und unterstützt unsere behördlichen Organe und medizinischen Einrichtungen in der Bewertung für weitere Maßnahmen im Pandemie/Epidemie-Fall.

:arrow_forward: ## Ansatz:
Diese Lösung soll sowohl für Nutzer als auch für behördliche Organe und medizinische Einrichtungen einen Mehrwert bieten. Auf der einen Seite sind es wir alle, die durch die Eingabe ihrer Symptome einen medizinischen Rat bekommen. Dieser wird entsprechend aufbereitet, dass dieser auch ohne ein Fachlexikon zu verstehen ist – es soll ihm Ruhe und Sicherheit geben. Ziel hierbei ist, dass er das Gefühl bekommt, medizinisch gut beraten zu sein. Für behördliche Organe und medizinische Einrichtungen können die identifizierten Krankheitsbilder mit anonymisierten Positionsinformationen aggregiert werden. Hierbei entsteht eine Landkarte mit Informationen von Krankheitsbildern (Heatmaps). Mit weitere Analysen und Mustererkennungen können weitere neue Informationen generiert werden – bspw. wo sich Krankheitsbilder derzeit ausbreiten. Dafür können Bewegungsprofile in die Analyse und Bewertung des Krankheitsbilds einbezogen werden.

:arrow_forward: ## Grundsatz:
Beide Seiten müssen einen Mehrwert von einem solchen System haben, damit ein solches System genutzt/gepflegt/weiterentwickelt und auch mit Informationen gefüllt wird.
Neben allem Mehrwert ist die Anonymität innerhalb der Daten zu gewährleisten.


