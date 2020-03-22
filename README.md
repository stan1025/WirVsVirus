﻿# Disease Pattern Early Recognition in Global Distribution!
<p align="center">
<img src="images/KeyVisual.jpg" height="400">
</p>
<p align="center">
<em>#WirVsVirus</em>
</p>

# Problembeschreibung
Viruserkrankungen sind Teil von unserem Leben. Jedes Jahr treten - vor allem in den Wintermonaten - 
"Erkrankungen durch saisonal zirkulierende, humane Influenzaviren"[1] auf. Dies erfolgt durch die Mutation der Viren, welche aber prognostiziert und daher gut therapiert werden können. 

Im Vergleich dazu gibt es Viren, "gegen [die] es in der Bevölkerung keine oder nur in einem kleinen Anteil der Bevölkerung eine vorbestehende Immunität gibt, [die] humanpathogen [sind] und [die] sich leicht von Mensch zu Mensch [verbreiten]" [1]. Der SARS-CoV-2 zählt zu diesen Viren. 

Durch eine immer engere länder- und kontinentenübergreifende Vernetzung der Menschen sowohl im gesellschaftlichem, als auch im wirtschaftlichen Kontext, ist die Ausbreitungsgeschwindigkeit für solche Viren deutlich gestiegen. Kommen dann noch lange Inkubationszeiten und unterschiedliche Krankheitsverläufe, wie bei Covid-19 dazu, wird auch die Ermittlung von Infektionsketten sowie die Vorhersage zukünftiger Hotspots von Infizierten erschwert. Aus diesen Gründen kann es schnell von einer Epidemie zu einer weltweiten Pandemie kommen. Dies steigert die Angst in der Bevölkerung, sich selber zu infizieren. 

Zusammengefasst sind die Hauptprobleme:

1. Eigenschaften der Viren zu Beginn des Auftretens unbekannt
2. Krankheitsverlauf unbekannt und unterschiedlich
3. Keine passende Therapie
4. Kein Impfstoff zur Verfügung
5. Ausbreitungsgeschwindigkeit sehr hoch
6. Ermittlung von Infizierten und Infektionsketten schwierig
7. Vorhersage von entstehenden Hotspots von Infizierten nicht gegeben
8. Steigende Angst in der Bevölkerung

Dies hat unter anderem zur Folge, dass Ärzte häufiger aufgesucht werden, eine hohe Dunkelziffer von Infizierten vorliegt und das gerade über milde Verläufe wenig bis keine Kenntnisse möglich sind. Dies zusammen kann zu einer Überlastung der öffentlichen und medizinischen Gesundheitssysteme führen. Um dem entgegen zu wirken, müssen Lösungen für die verschiedenen Probleme entwickelt werden. 

[1] Nationaler Pandemieplan Teil II. "Wissenschaftliche Grundlagen." Robert Koch-Institut, März 2017.

# Lösung
Im Rahmen des Hackathons haben wir eine Lösung entwickelt, die die Probleme 2, 6, 7 und 8 aus der Problembeschreibung adressiert. Hierfür haben wir ein App-Konzept sowie eine prototypische Umsetzung entwickelt. Die App soll 

- Daten, wie Symptomausprägung und Positionsdaten, vom Nutzer entgegennehmen,
- diese Datenanalysealgorithmen verarbeiten,
- die Ergebnisse dem Nutzer in einfacher und verständlicher Weise anzeigen sowie
- Schnittstellen für andere Datennutzer (z. B. Regierung, medizinische Forschung) zur Verfügung stellen.

Auf dem Weg zur Entwicklung des Click-Dummies und der technischen Umsetzung waren mehrere Schritte notwendig. Als erstes haben wir die Zielgruppe unserer App definiert. Schnell war klar, dass wir mit der App alle Bürgerinnen und Bürger Deutschlands erreichen wollen. Denn je mehr Menschen ihre Symptom- und Positionsdaten zur Verfügung stellen, desto größer ist die Datengrundlage und die Genauigkeit der Auswertung und somit der Schutz aller. Um bei der Entwicklung aber ein konkretes Bild unserer Zielgruppe vor Augen zu haben, haben wir 4 Personas entwickelt, die prototypische Vertreter der Zielgruppe darstellen. Parallel haben wir zwei Umfragen aufgesetzt, in denen wir nach Nutzungsmotiven für die App gefragt haben, und nach bereits existierenden Lösungen recherchiert. Aus den Ergebnissen der Personas, Umfragen und der Recherche haben wir schließlich Funktionen definiert, die die App enthalten sollte. Die Recherche der bereits existierenden Lösungen ergab, dass diese weder alle oben genannten Probleme addressieren noch unsere definierten Funktionen voll umfassen. Das unterstützte uns in der Entscheidung ein eigenes App-Konzept zu erstellen, umzusetzen und zu implementieren. So entstanden ein Click-Dummy sowie eine prototypische Implementierung, auf denen im Anschluss an den Hackathon weiter aufgebaut werden soll. 

# Personas

In einem ersten Schritt wurden die Zielgruppen unserer App definiert: die allgemeine Bevölkerung, öffentliche Einrichtungen undd medizinische Einrichtungen. Es wurde sich auf die Gruppe Bevölkerung fokussiert, da diese Gruppe die App später nutzen soll. Die anderen beiden Zielgruppen benötigen die Eingabe und treten daher zunächst in den Hintergrund. Bei der Bevölkerung wurde eine weitere Unterscheidung bezüglich dem Gesundheitszustand getroffen: Gesunde Person, Person mit Vorerkrankungen aber symptomfrei und Person mit Symptomen. Hierbei waren die ersten beiden von besonderem Interesse, da diese von einer Nutzung der App überzeugt werden müssen. Aus diesem Grund wurde für diese Gruppen Peronas definiert. Insgesamt konnten vier verschiedene Personas erstellt werden. 

## Robert

Die erste Person ist Robert, 32 Jahre und Arbeiter in der Mittelschicht. Er ist derzeit gesund, hat keine Vorerkrankungen und erkennt nicht den Ernst der Lage. Er besitzt mehrere digitale Geräte und beherrscht diese gut. Er nutzt verschiedenste Medien zum Informieren und Austauschen mit anderen. Da er derzeit gesund ist und den Ernst der Lage nicht erkennt, muss eine App für ihn einen richtigen Mehrwert bieten, damit er diese nutzt. 

<p align="center">
<img src="images/PersonaRobert.PNG" height="400">
</p>

## Gabi

Die zweite Person ist Gabi, 48 Jahre, Hausfrau und hat zwei Kinder. Sie ist derzeit gesund, hat keine Vorerkrankungen ist aber leicht besorgt um sich und ihre Kinder. Sie besitzt ein Smartphone und einen PC und kann mit beiden grundlegend umgehen. Sie nutzt verschiedenste Medien zum Informieren und zum Austauschen, wobei sie sich hierbei auf die bekanntesten beschränkt. Sie würde eine angebotene App regelmäßig für sich und ihre Kinder nutzen. Da sie aber viel hat, kann es vorkommen, dass sie die Nutzung auch mal vergisst.

<p align="center">
<img src="images/PersonaGabi.PNG" height="400">
</p>

## Ernst

Die dritte Person ist Ernst, 70 Jahre und Rentner. Er ist derzeit gesund, hat aber bereits Vorerkrankungen und ist daher panisch besorgt um seine Gesundheit. Aufgrund seines hohen Alters besitzt er zwar ein Smartphone kann dies aber nur für einfache Anwendungen nutzen. Nachdem die Kinder ihm gezeigt haben, wie eine Anwendung funktioniert, kann er diese auch nutzen. Er informiert sich vorallem im öffentlich, rechtlichen Fernsehen sowie in Printmedien. Er würde, sofern er die App verstanden hat, diese mehrmals täglich nutzen, um stets sein Gewissen zu beruhigen. 

<p align="center">
<img src="images/PersonaErnst.PNG" height="400">
</p>

## Anna

Die letzte Person ist Anna, 20 Jahre und Studentin. Sie ist gesund und hat keine Vorerkrankungen. Spaß steht bei ihr im absoluten Fokus, sie macht sich aus allem einen Spaß und provoziert gerne. Sie gehört zur Generation digital native und informiert sich daher fast ausschließlich über Social Media. Sie würden den Sinn der App nicht verstehen und sich einen Spaß daraus machen, die App mit falschen Eingaben zu nutzen. 

<p align="center">
<img src="images/PersonaAnna.PNG" height="400">
</p>

# Umfragen und Ermittlung der Herausforderungen

Die App liefert nur dann eine ausreichende Datengrundlage, wenn eine Vielzahl an Menschen diese regelmäßig nutzt. Deshalb ist es wichtig, im Vorfeld die Nutzerbedürfnisse zu ermitteln. Aus diesem Grund haben wir eine Umfrage erstellt, um herauszufinden, welchen Funktionsumfang die App haben muss und welchen Mehrwert sie für eine tägliche Nutzung bieten muss. Wir haben die Umfrage sowohl im Slack-Channel des Hackathons als auch über unsere Kanäle verteilt. Insgesamt haben 451 Personen an der Umfrage teilgenommen, 101 Personen im Slack-Channel und 350 an der öffentlich verteilten Umfrage.

Die Ergebnisse der Slack-Umfrage sind in Abbildung 1 dargestellt. Es ist klar zu erkennen, dass den Nutzern vor allem die Diagnose der Symptome, die Darstellung von Regionen mit der Infiziertenanzahl sowie die Gewährleistung des Datenschutz wichtig sind. Auch die öffentlich verteilte Umfrage (siehe Abbildung 2 und 3) zeigt die gleichen Ergebnisse. Da hier noch weitere Möglichkeiten abgefragt wurden, konnten weitere Funktionen die einem Nutzer wichtig sind ermittelt werden. Neben den oben genannten Funktionen ist den Nutzern die Usability, die fachlich fundierte Risikoeinschätzung sowie eine Benachrichtigung bei Kontakt mit Infizierten wichtig. Zusätzlich wurde in der Umfrage noch gefragt, wie man die Nutzer zur täglichen Eingabe der Symptome motivieren kann. Hierbei ist den Nutzern der Datenschutz am wichtigsten gefolgt von der Darstellung der Infiziertenanzahl in einer Region. 

Die Nutzer konnten am Ende der Umfrage noch mitteilen, was ihnen zusätzlich wichtig bei der Nutzung einer solchen App ist. Hierbei gab es insgesamt 89 Antworten mit Häufungen in den Themenfeldern Datenschutz (26 Nennungen), Keine Panikmache/Verunsicherung (10 Nennungen), Verwendung seriöser Quellen/ Empfohlen von öffentlichen Stellen (10 Nennungen) und einfache Benutzeroberfläche/Bedienung (8 Nennungen).

Zusammengefasst konnten 13 Leitfragen in drei Hauptgruppen ermittelt werden, die von einer App positiv beantwortet werden müssen, damit diese flächendeckend genutzt wird:

- Akzeptanz in der Gesellschaft
	- Wird der Datenschutz sichergestellt?
	- Ist die Seriosität gewährleistet?
	- Wurde eine mögliche Verunsicherung der Bevölkerung aufgrund der Ergebnisdarstellung berücksichtigt?
- Nutzung der App
	- Wie kann sichergestellt werden, dass die App regelmäßig genutzt wird?
	- Wie kann sichergestellt werden, dass jeder Bürger (auch gesunde) die App nutzen?
	- Wie kann sichergestellt werden, dass keine absichtlich falschen Eingaben getätigt werden?
- Technische Umsetzung
	- Gibt es Möglichkeiten der Symptomerfassung?
	- Gibt es Möglichkeiten der Standorterfassung?
	- Gibt es Algorithmen zur Ermittlung von Infektionsketten?
	- Gibt es Algorithmen zur Vorhersage von Hotspots von Infizierten?
	- Gibt es Algorithmen zur Einschätzung der Symptome?
	- Gibt es Konzepte zur Erweiterung?
	- Gibt es Möglichkeiten zur Einbindung in andere Systeme?


<p align="center">
<img src="images/Polly.JPG">
</p>
<p align="center">
<em>Abbildung 1: Slack-Umfrage</em>
</p>

<p align="center">
<img src="images/umfrage_Frage1.PNG">
</p>
<p align="center">
<em>Abbildung 2 Öffentliche Umfrage Teil I</em>
</p>

<p align="center">
<img src="images/umfrage_Frage2.PNG">
</p>
<p align="center">
<em>Abbildung 3 Öffentliche Umfrage Teil II</em>
</p>


# Analyse exisiterender Lösungen

Die Idee zum **#WirVsVirus** Hackathon der deutschen Bundesregierung entstand aus dem am vorigen Wochenende in Estland erfolgreich veranstalteten Hackathon. Unter den Einreichungen waren, neben einer App für die Einrichtung von täglichen Routinen, auch zahlreiche Vorschläge über Apps zum Tracking und zur Selbstdiagnose. 
[t3n: Bundesregierung startet Hackathon](https://t3n.de/news/bundesregierung-wirvsvirus-1263682/ "t3n digital pioneers")

Mit 54 Teams ist in Deutschland **Corona Tracking** das mit Abstand am meisten bearbeitete Thema. Es gibt bereits multiple Lösungen und auch das Robert Koch Institut beschreibt in  ihrem [Pandemieplan]([https://www.rki.de/DE/Content/InfAZ/I/Influenza/Pandemieplanung/Downloads/Pandemieplan_Teil_II_gesamt.pdf?__blob=publicationFile](https://www.rki.de/DE/Content/InfAZ/I/Influenza/Pandemieplanung/Downloads/Pandemieplan_Teil_II_gesamt.pdf?__blob=publicationFile)) ein Surveillancesystem : 
> Surveillancesysteme dienen der systematischen, kontinuierlichen Erhebung, Zusammenstellung, Analyse und Bewertung von Daten sowie der zeitnahen, kontinuierlichen Berichterstattung der Ergebnisse. Bei der Etablierung von Influenzasurveillancesystemen sind die Repräsentativität der Datenquellen, das Erheben von Daten für die verschiedenen Schweregrade der Erkrankung und das Erfassen von Bezugsgrößen wichtige Qualitätskriterien. Für die Bewertung von Surveillancedaten in einer Influenzapandemie sind historische saisonale Daten zum Vergleich notwendig.

Dabei sieht das RKI ethische, sowie datenschutzrelevante Herausforderungen beim Erzeugen und im Umgang mit den Gesundheits- und Positionsdaten. Sie gehen davon aus, dass mathematische Modelle bei der Auswertung eine große Rolle spielen werden, die Qualität aber von der Datengrundlage abhängt. Auf Basis der Datenlage sollen differenzierte Lagebeurteilungen der Situation in Deutschland möglich sein. 

Im Folgenden sollen bestehende und veröffentlichte Lösungen unter drei Gesichtspunkten verglichen werden. Die Funktion steht im Mittelpunkt der Betrachtung. Die Nutzerfreundlichkeit und der Datenschutz sind darüberhinaus zwei weitere Aspekte, die den Erfolg und die Akzeptanz der Bürger maßgeblich beeinflussen. 

Gesundheitsassistentinnen wie [AVA](https://ada.com/de/) oder [Vivy](https://www.vivy.com/) beraten die Bürger bereits seit längerem zu ihrer Gesundheit. Es können Gesundheitsdaten eingegeben werden und von Symptomen mögliche Diagnosen abgeleitet werde. Doch dabei geben Benutzer sehr private Informationen kund. Wegen mangelndem Datenschutz standen die beiden Services in der Vergangenheit immer wieder in der [Kritik]([https://www.aerzteblatt.de/nachrichten/106679/Gesundheits-App-Ada-wegen-Datenschutz-in-der-Kritik](https://www.aerzteblatt.de/nachrichten/106679/Gesundheits-App-Ada-wegen-Datenschutz-in-der-Kritik)). 

Ganz ähnlich funktioniert eine der bekannteste Corona-Applikation in Deutschland, die [CovApp](https://www.charite.de/forschung/forschung_aktuell/pressemitteilung/artikel/detail/coronavirus_charite_startet_corona_app_covapp/) der Charité Berlin. 

>Mit der CovApp und dem dahinterstehenden Fragebogen bekommen Berlinerinnen und Berliner bereits zu Hause eine Entscheidungshilfe, ob sie die Untersuchungsstelle aufsuchen sollten und ob ein COVID-19-Test sinnvoll ist. [...] Darüber hinaus gibt die CovApp Informationen, wie sich das eigene Infektionsrisiko reduzieren lässt.

Da die Charité eine sehr anerkannte medizinische Institution ist, bekommen die Ergebnisse des Tests und die Handlungsempfehlungen große Glaubwürdigkeit. Der sachliche und schlichte Aufbau der App trägt dazu bei. Besorgte Bürger bekommen eine fundierte Aussage über eine mögliche Infektion und werden gegebenenfalls  beruhigt. Die App trägt bedeutend zu der Reduzierung des Ansturms auf Ärzte und Krankenhäuser bei. Nur einzelnen Fällen wird geraten mit einer Zusammenfassung des Test sich an medizinisches Personal zu wenden. 
Allerdings werden vermutlich keine weiteren Informationen über die Teilnehmer des Tests ausgewertet, gespeichert oder weiterverarbeitet. Personen denen geraten wurde einen Arzt aufzusuchen, könnten die ärztliche Diagnose zurück in die App geben und somit den Algorithmus verbessern. Die systematische und regelmäßige Abfrage der Symptome einzelner Personen und der Veränderung über die Zeit, könnte dazu führen die Krankheit und ihr auftreten besser zu verstehen. Die Verknüpfung der Testeingaben mit Positionsdaten könnte Aufschluss darüber ermöglichen in welcher Region Bürger vermehrt Symptome erleiden und ob es sich um ein Risikogebiet handelt. Durch weitere Darstellungen und Informationen in der App könnte die Sorge der Bevölkerung gelindert werden und viele Informationen an einem Ort zur Verfügung gestellt werden. 

Der [Corona Detector](https://coronadetector.com/) ist eine Anwendung, die von Studenten entwickelt worden ist. Diese soll nach Beantwortung eines kurzen Fragebogens eine Orientierung anhand von Empfehlungen der WHO geben. Die Anwendung ist grafisch schön aufbereitet und biete eine einfache Bedienung. Im Gegensatz zu der Charité App fehlt leider eine offizielle Institution, die Glaubwürdigkeit vermittelt. Die Anwendung vermittelt nicht den Anschein, dass die Daten weiterverarbeitet und ausgewertet werden, deshalb ist Datenschutz keine Hürde. 

Das [Faster than Corona](https://www.fasterthancorona.de/#questionnaire) Team erhebt auch Daten über Symptome. 
>Teilen Sie uns mit, wie es Ihnen geht, oder ob sie schon einen Corona-Test gemacht haben. Daten spenden kann jeder, egal ob krank oder gesund. Mithilfe einer Künstlichen Intelligenz wollen wir nach Mustern in den Daten suchen und so auf medizinische Zusammenhänge stoßen, die bisher verborgen blieben 

Durch eine wirklich kurze Checkliste ist die Bedienbarkeit einfach. Darüber hinaus ist die Seite mit nützlichen, zusätzlichen Informationen, wie einer Infektionskarte und einem FAQ über Corona gefüllt. Damit erhöht die Seite ihren Informationsgehalt und die Attraktivität. 

Einen anderen Ansatz verfolgen die Wissenschaftler hinter der [Geohealth App](https://www.geohealthapp.de/). 
>Die grundlegende Funktion beruht darauf, dass die Location Histories von Indexpatienten (Corona-positive Mitbürger) mit denen von potenziellen Kontaktpersonen abgeglichen werden können. Ein Risikomodell berechnet dann aus Faktoren wie Entfernung der Personen zueinander und Dauer des Kontakts das mögliche Infektionsrisiko.

Ein entscheidender Faktor im Kampf gegen die Verbreitung der Pandemie ist die Nachvollziehbarkeit von Infektionsketten und Definition von Risikogebieten.  Mit Hilfe der App können diese Informationen besser erhoben werden. Die Daten müssen zum jetzigen Zeitpunkt von der infizierten Personen gespendet werden. Das setzt eine hohe Interaktionsfreudigkeit mit der Anwendung und eine breite Akzeptanz voraus, um einen sinnvollen Effekt zu erzielen. Dieses wird von den Machern als digitale Impfung bezeichnet, wenn nur ca. 3% der Bevölkerung mitmachen, zeige es keine Wirkung. Lediglich mit der Mehrheit der Daten von Indexpersonen kann eine flächendeckende Funktion gewährleistet werden. Die Umfrage von Heise und weitere von unserer Gruppe durchgeführte Umfrage zeigen eine generelle Bereitschaft der Bürger ihre Daten zur Verfügung zu stellen. 

<p align="center">
<img src="images/umfrage_1.PNG">
</p>

Einerseits können sich die Mitbürger darüber Informationen einholen, ob bei Ihnen innerhalb der letzten Tage ein Kontakt zu einem positiven Mitbürger bestand, um so beispielsweise grippale Symptome besser einzuschätzen. Andererseits können sich die Benutzer der App an einer Übersichtskarte orientieren, wie viele Menschen in Ihrer näheren Umgebung infiziert wurden.

Doch dabei gibt es große Bedenken! Wie auch bei den medizinischen Daten, geben GPS-Daten einen großen Aufschluss über Individuen und sind besonders stark zu schützen. Dadurch ergeben sich Herausforderungen mit dem Datenschutz. 

Datenschutz ist vor allem in der westlichen Welt eine wichtige Angelegenheit.
Das Vorgehen und die Methoden der Behörden in Chinas und Südkoreas unterscheiden sich davon grundlegend.
Südkorea hat eine Handyapp an seine Bürger ausgerollt, die anhand von GPS Daten kontrolliert, ob sie die verordnete Quarantäne einhalten. Gegebenenfalls wird ein Verstoß an zuständige Beamte gemeldet. Die App kann auch dazu genutzt werden Symptome und den Krankheitsverlauf an die zuständigen Beamten weiterzugeben.  Diese Beispiel zeigt, dass es technisch möglich ist diese Funktionen umzusetzen. 

Damit die Bürger nicht ein Gefühl von Überwachung und Machtlosigkeit bekommen, ist die Art und Weise mit derart persönlichen Daten umzugehen essentiell. Zum Schutz der Daten haben Forscher am MIT eine neue Technologie entwickelt mit Geodaten umzugehen. 

Die [Private Kit](http://privatekit.mit.edu/)  Entwickler beschreiben in einem [Whitepaper]([https://arxiv.org/pdf/2003.08567.pdf](https://arxiv.org/pdf/2003.08567.pdf)) die Entwickler die Herausforderungen und die technische Umsetzung.  
>We seek to outline the different technological approaches to mobile-phone based contact-tracing to date and elaborate on the opportunities and the risks that these technologies pose to individuals and societies. We describe advanced security enhancing approaches that can mitigate these risks and describe trade-offs one must make when developing and deploying any mass contact-tracing technology

Sie entwickelten einen Algorithmus bei dem Bewegungsprofile erstellt werden, die Daten allerdings nie das Gerät des Benutzers verlassen. Diese Lösung stellen sie *Open Source* zur Verfügung. 
Das Onlinemedium Wired hat dazu einen sehr differenzierten [Artikel](www.wired.com/story/phones-track-spread-covid19-good-idea/) geschrieben, der sowohl Vor- als auch Nachteile beleuchtet. 
Diese Technologie könnte die Akzeptanz der Bürger erhöhen, wenn diese verstehen, dass die verwendeten Daten sicher sind. Denn bei der Verwendung ist es essentiell, dass viele Individuen teilnehmen um eine fundierte Datenbasis zu bekommen.
Allerdings gibt es auch Beschränkungen der verwendeten Daten. Neuste [Studien](https://journals.plos.org/plosone/article?id=10.1371/journal.pone.0219890)  belegen, dass mobile GPS Daten nur eine Genauigkeit zwischen 7-13 Metern haben. Da sich das Corona Virus nur in einem Bereich bis 2 Metern übertragt, kann keine hunderprozentige Aussage darüber getroffen werden, ob zwei Personen wirklich in diesem Bereich waren. Trotzdem ermöglichen diese Daten eine gute Grundlage, gerade wenn Personen sich länger an einem Ort aufgehalten haben oder zusammen eine Strecke zurücklegen. 

## Fazit:
Wie man an diesem kurzen Überblick an bestehenden Anwendungen sehen kann, gibt es bereits eine Vielzahl innovativer Lösungen. In ihrem jeweiligen Bereich bieten sie einen großen Mehrwert für die Funktion für welche sie erstellt wurden. 
Da es bei einer Pandemie allerdings auf eine überregionale, nationale, sogar internationale Betrachtung ankommt, müssen große Datenmengen erzeugt werden. Dafür muss man einen großen Pool an Individuen von der Nutzung der jeweiligen App überzeugen. 
Deshalb ist es sinnvoll die verschiedenen Funktionen in einer Anwendung zu vereinen. Dadurch kann man medizinische mit geographischen Daten in Verbindung setzen, die Daten für die Forschung, die Behörden und die Bürger verwenden. 

# Definition der Funktionen
 
 Aus den Ergebnissen von Personas, Umfragen und Recherchen konnten wir konkrete Funktionen für die App definieren. Dabei haben wir die Perspektive der Nutzer eingenommen: Welche Funktionen können für Nutzer hilfreich sein? Welche Funktionen wünschen sich Nutzer? Welche Funktionen möchten wir anbieten? 
 
 Am Anfang jeder User Journey steht der Download und das erste Öffnen einer App. Rund um diesen Part sollte es aus unserer Sicht fünf Funktionen geben:
 
<p align="center">
<img src="images/Funktionsdefinition.png">
</p>
 
 Startet ein Nutzer das erste Mal unsere App, erhält er ein ausführliches Onboarding. In dem Onboarding wird dem Nutzer kurz und prägnant aufgezeigt, was die Idee hinter der App ist und welchen Mehrwert der Nutzer von dieser App, sowie die Anonymisierung seiner Daten und Gewährleistung seiner Privatsphäre versprochen. Danach wird der Nutzer darum gebeten sich zu registrieren. Nach erfolgreicher Registrierung erfolgt der Login. Als erstes soll der Nutzer dann für eine genauere Analyse seine aktuellen Gesundheitsdaten und Vorerkrankungen eingeben. Diese werden in seinem Profil hinterlegt, in welchem er diese immer wieder anpassen kann. Hat der Nutzer den ersten Teil abgeschlossen, öffnet sich der Startbildschirm der App und der Nutzer bekommt ein Tutorial angezeigt, das er (optional) anschauen kann. Danach startet die eigentliche Nutzung der App.

 <p align="center">
<img src="images/Funktionsdefinition_2.png">
</p>
 
Die Hauptfunktion der App ist die Eingabe der Symptome. In einer Eingabemaske kann der Nutzer jeden Tage seine aktuellen Symptome sowie deren Ausprägung eingeben. Dies ist sowohl für ihn selbst als auch für andere möglich. Letztes ist vor allem für Familien mit Kindern oder älteren Menschen relevant, die kein eigenes Smartphone besitzen, um die Daten selbst einzugeben. Auch kann das Ergebnis eines eventuellen Covid-19-Tests eingegeben werden. Der Nutzer kann sich nach der Eingabe seine Symptome ansehen. Dabei werden ihm diese für den heutigen Tag angezeigt sowie ein Verlauf, beispielsweise über die letzten zwei Wochen. So kann der Nutzer selbst seinen Gesundheitszustand überwachen.

Um einen größeren Mehrwert für den Nutzer zu generieren, könnte es eine Kartendarstellung von Risikogebieten geben. Auf diesen Karten wird dem Nutzer ganz Deutschland in Regionen eingeteilt angezeigt. Die Regionen werden nach ihrem Risiko beurteilt: geringes, mittleres oder hohes Risiko. So kann der Nutzer sehen, welche Regionen gerade ein besonders großes Risiko zeigen. Zudem kann der Nutzer sich seinen Standort anzeigen lassen und so sehen, ob er sich in einem Risikogebiet befindet. Je nach Höhe des Risikos in seinem Gebiet, wird ihm eine Empfehlung ausgesprochen. In einem Hochrisikogebiet könnte die Empfehlung lauten "Bleiben Sie zuhause.". 

Um den Nutzer daran zu erinnern, seine Symptome täglich einzugeben, sollte es Erinnerungsfunktion geben. Diese könnte in Form von Push-Notifications realisiert werden. Der Nutzer könnte beispielsweise täglich per Push an die Eingabe seiner Symptome erinnert werden. 

Zusätzlich zu den wichtigsten Funktionen könnte die App dem Nutzer Informationen zur Verfügung stellen. Das könnten Informationen sein zu dem Virus Covid-19, Symptomen und Krankheitsverlauf. Auch Hygienemaßnahmen und Verhaltensregeln sowie aktuelle Zahlen und Statistiken und Anlaufstellen können den Mehrwert der App erhöhen. 

Funktionen, die in fast jeder App zu finden sind und auch hier nicht fehlen sollten, sind Einstellungen (z.B. Einstellung von Schrift- und Icongröße) und das Profil. 
 
Wir haben Funktionen definiert, die für uns in der täglichen Nutzung der App wichtig sind. Diese Liste ist nicht als erschöpfend zu betrachten. Die Entwicklung einer App ist dynamisch. So können Funktionen im Laufe der Entwicklung hinzugefügt, gelöscht oder durch andere ersetzt werden. Aber diese Liste stellt unsere Leitlinie und einen Ausgangspunkt für weitere Entwicklungen dar. 
# Data Analysis Algorithm


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



# Click-Dummy

Zur besseren Darstellung und zum Test der Software wurde ein Click-Dummy erstellt. Der Click-Dummy wurde auf der professionellen Software Adobe XD aufgesetzt. Der Funktionsumfang wurde anhand der Umfrage und dem Vergleich mit anderen Apps erstellt.

Dargestellt im Mockup:
- Ersteinrichtung
- Tageseingabe
- Handlungsempfehlung
- Zone-Maps 
- Daily Push-Benachrichtigung
- Sharing-Funktion
Der Mockup ist online abrufbar unter: https://xd.adobe.com/view/130f088c-c69f-434f-7976-110ea7221138-653e/?fullscreen

Basierend auf dem ersten Entwurf sollte weitergearbeitet werden, um eine vollumfängliche App mit einem guten User Interface und einer guten User Expirience zu erhalten.

# Nächste Schritte
Nach dem Hackathon kann der entwickelte und implementierte Prototyp um die genannten Funktionen ergänzt und optimiert werden. Ein weiterer Austausch mit Experten wäre ratsam. Dazu zählt medizinisches Fachpersonal zur Auswertung der Symptomdaten mit Hilfe des Algorithmus, Experten im Bereich Psychologie zur Aufbereitung und Vermittlung der Daten, um Panikmache/zusätzliche Verunsicherung in der Bevölkerung zu vermeiden und Experten im Bereich Datenschutz, um eine vollständige Anonymisierung der Daten zu gewährleisten. Darüber hinaus könnten andere Projekte in der App verwendet oder verlinkt werden, beispielsweise zur Visualisierung von Daten. Für die Zukunft haben wir uns bereits mit Beteiligten der CovApp und Geohealth dazu verabredet gemeinsam Absprachen zu treffen, um nicht nebeneinander her zu entwickeln.
Es gilt Herausforderungen wie den Datenschutz der medizinischen und geographischen Daten zu wahren. Damit und mit einem attraktiven User Interface wollen wir die Akzeptanz der App in der Bevölkerung erhöhen, denn je höher die Nutzerzahl, desto besser die Datenlage und die Analysen.

# Teamvorstellung
Wir sind ein vielfältiges Team aus dem deutschlandweiten Netzwerk der Studenten und Jungingenieure des VDI (Verein Deutscher Ingenieure e.V.).	Wir sind ein bunt gemischtes Team, zu Beginn alles Mitglieder/Freunde des Netzwerks der Studenten und Jungingenieure des VDI (Verein Deutscher Ingenieure). Zum Teil kannten wir uns vor der Zusammenarbeit noch nicht. Im weiteren Verlauf des Hackathons haben wir uns mit Experteninnen und Experten verschiedener Fachrichtungen ausgetauscht und ergänzt. Wir haben das ganze Wochenende unglaublich gut zusammen gearbeitet und mit viel Witz und Spaß eine tolle App entwickelt! 	

Unser Team:

**System Entwicklung / Hacking** Architektur / Entwicklung von skalierbaren mikro-service orientierten Architekturen
- Andreas Stutz (Ideengeber, Entwickler, Architektur )
- Benedikt Geib (REST-API / Mobile App)
- Janik Ritz (Data Persistance)
- Melanie Wassmer (Mobile App)
- Philipp Gesner (Datenanalyse)
- Marwin Madsen (Mobile App)

**Scientific Research**
- Kathrin Korte (Datenanalyse Algorithmus)
- Charlotte Maschke

**Public Research**
- Luisa Miny (User Experience, Video Konzept)
- Torben Deppe (Recherche, Projektmanagement)
- David Seck (Recherche, externe Kommunikation)
- Vincent Laux (MockUp / Umfragen)
- Riadh Dhaoui (Video Design)
- Jonas Thees (Datenschutz)
- Johanna Hoppe (Umfragen Auswertung, Video Konzept)	

# Liste der Archive

**Cloud Anwendung**
https://github.com/stan1025/WirVsVirus

Ein besonderer Dank gilt Amazon Web Service insbesondere Pawel Warmuth für die großartige Unterstützung beim Zugang und der Bedienung!

**Mobile Anwendung**
https://github.com/stan1025/WirVsVirus_App


Für mehr informationen zu unserer App folge diesem Link: ["Disease-pattern-early-recognition-in-global-distribution"](https://devpost.com/software/disease-pattern-early-recognition-in-global-distribution#updates)
