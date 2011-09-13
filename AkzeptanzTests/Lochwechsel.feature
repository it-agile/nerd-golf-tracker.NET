Feature: Lochwechsel

Scenario: Schlagzahl zuruecksetzen
	Given ich habe den Ball einmal geschlagen,
	When ich zum nächsten Loch gehe,
	And ich nun den Ball schlage,
	Then zählt der NerdGolfTracker 1 Schlag.

Scenario: Loch hochzaehlen
	When ich zum nächsten Loch gehe,
	And ich nun den Ball schlage,
	Then zählt der NerdGolfTracker die Schläge auf dem 2. Loch.