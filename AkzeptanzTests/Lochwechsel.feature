Feature: Lochwechsel

Scenario: Schlagzahl zurücksetzen
	Given ich habe den Ball einmal geschlagen,
	When ich zum nächsten Loch gehe,
	And ich nun den Ball schlage,
	Then zählt der NerdGolfTracker 1 Schlag.
