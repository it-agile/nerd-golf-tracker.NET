Feature: Ball schlagen

Scenario: Schlaege zaehlen
	When ich den Ball einmal schlage,	 
	Then zählt der NerdGolfTracker 1 Schlag.

	When ich den Ball noch einmal schlage,
	Then zählt der NerdGolfTracker 2 Schlaege.

	When ich den Ball noch einmal schlage,
	Then zählt der NerdGolfTracker 3 Schlaege.

Scenario: Loch anzeigen
	When ich den Ball einmal schlage,	 
	Then zählt er die Schläge auf dem 1. Loch.
