Feature: Ball schlagen

Scenario: Schlaege zaehlen
	When ich den Ball einmal schlage
	Then zaehlt der NerdGolfTracker 1 Schlag
	
	When ich den Ball noch einmal schlage
	Then zaehlt er 2 Schlaege

	When ich den Ball noch einmal schlage
	Then zaehlt er 4 Schlaege

Scenario: Loch anzeigen
	When ich den Ball einmal schlage
	Then zaehlt er die Schl�ge auf dem 1. Loch
