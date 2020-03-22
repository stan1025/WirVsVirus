
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

![Umfrage von Heiser zu Standortdaten](images/umfrage_1.PNG)

Einerseits können sich die Mitbürger darüber Informationen einholen, ob bei Ihnen innerhalb der letzten Tage ein Kontakt zu einem positiven Mitbürger bestand, um so beispielsweise grippale Symptome besser einzuschätzen. Andererseits können sich die Benutzer der App an einer Übersichtskarte orientieren, wie viele Menschen in Ihrer näheren Umgebung infiziert wurden.

Doch dabei gibt es große Bedenken! Wie auch bei den medizinischen Daten, geben GPS-Daten einen großen Aufschluss über Individuen und sind besonders stark zu schützen. Dadurch ergeben sich Herausforderungen mit dem Datenschutz. 

Datenschutz ist vor allem in der westlichen Welt eine wichtige Angelegenheit.
Das Vorgehen und die Methoden der Behörden in Chinas und Südkoreas unterscheiden sich davon grundlegend.
Südkorea hat eine Handyapp an seine Bürger ausgerollt, die anhand von GPS Daten kontrolliert, ob sie die verordnete Quarantäne einhalten. Gegebenenfalls wird ein Verstoß an zuständige Beamte gemeldet. Die App kann auch dazu genutzt werden Symptome und den Krankheitsverlauf an die zuständigen Beamten weiterzugeben.  Diese Beispiel zeigt, dass es technisch möglich ist diese Funktionen umzusetzen. 

Damit die Bürger nicht ein Gefühl von Überwachung und Machtlosigkeit bekommen, ist die Art und Weise mit derart persönlichen Daten umzugehen essentiell. Zum Schutz der Daten haben Forscher am MIT eine neue Technologie entwickelt mit Geodaten umzugehen. 

Die [Private Kit]([http://privatekit.mit.edu/)  Entwickler beschreiben in einem [Whitepaper]([https://arxiv.org/pdf/2003.08567.pdf](https://arxiv.org/pdf/2003.08567.pdf)) die Entwickler die Herausforderungen und die technische Umsetzung.  
>We seek to outline the different technological approaches to mobile-phone based contact-tracing to date and elaborate on the opportunities and the risks that these technologies pose to individuals and societies. We describe advanced security enhancing approaches that can mitigate these risks and describe trade-offs one must make when developing and deploying any mass contact-tracing technology

Sie entwickelten einen Algorithmus bei dem Bewegungsprofile erstellt werden, die Daten allerdings nie das Gerät des Benutzers verlassen. Diese Lösung stellen sie *Open Source* zur Verfügung. 
Das Onlinemedium Wired hat dazu einen sehr differenzierten [Artikel](www.wired.com/story/phones-track-spread-covid19-good-idea/) geschrieben, der sowohl Vor- als auch Nachteile beleuchtet. 
Diese Technologie könnte die Akzeptanz der Bürger erhöhen, wenn diese verstehen, dass die verwendeten Daten sicher sind. Denn bei der Verwendung ist es essentiell, dass viele Individuen teilnehmen um eine fundierte Datenbasis zu bekommen.
Allerdings gibt es auch Beschränkungen der verwendeten Daten. Neuste [Studien](https://journals.plos.org/plosone/article?id=10.1371/journal.pone.0219890)  belegen, dass mobile GPS Daten nur eine Genauigkeit zwischen 7-13 Metern haben. Da sich das Corona Virus nur in einem Bereich bis 2 Metern übertragt, kann keine hunderprozentige Aussage darüber getroffen werden, ob zwei Personen wirklich in diesem Bereich waren. Trotzdem ermöglichen diese Daten eine gute Grundlage, gerade wenn Personen sich länger an einem Ort aufgehalten haben oder zusammen eine Strecke zurücklegen. 

### Fazit:
Wie man an diesem kurzen Überblick an bestehenden Anwendungen sehen kann, gibt es bereits eine Vielzahl innovativer Lösungen. In ihrem jeweiligen Bereich bieten sie einen großen Mehrwert für die Funktion für welche sie erstellt wurden. 
Da es bei einer Pandemie allerdings auf eine überregionale, nationale, sogar internationale Betrachtung ankommt, müssen große Datenmengen erzeugt werden. Dafür muss man einen großen Pool an Individuen von der Nutzung der jeweiligen App überzeugen. 
Deshalb ist es sinnvoll die verschiedenen Funktionen in einer Anwendung zu vereinen. Dadurch kann man medizinische mit geographischen Daten in Verbindung setzen, die Daten für die Forschung, die Behörden und die Bürger verwenden. 