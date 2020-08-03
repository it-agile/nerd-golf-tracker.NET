Feature: Unbekannte Eingabe

@ignore
Scenario: Unbekannte Eingabe
	When ich eine dem NerdGolfTracker unbekannte Eingabe mache
	Then weist mich der Tracker auf die Hilfe hin