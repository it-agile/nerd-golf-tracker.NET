Feature: Lochwechsel

@ignore
Scenario: Schlagzahl zuruecksetzen
	Given ich habe den Ball einmal geschlagen
	When ich zum naechsten Loch gehe
	And nun den Ball schlage
	Then zaehlt der NerdGolfTracker 1 Schlag

Scenario: Loch hochzaehlen
	When ich zum naechsten Loch gehe
	And nun den Ball schlage
	Then zaehlt der NerdGolfTracker die Schlaege auf dem 2. Loch