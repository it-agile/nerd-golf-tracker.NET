Feature: Ball schlagen

Scenario: Ball einmal schlagen
	When ich den Ball einmal schlage,	 
	Then zählt der NerdGolfTracker 1 Schlag.

	When ich den Ball noch einmal schlage,
	Then zählt der NerdGolfTracker 2 Schlaege.

	When ich den Ball noch einmal schlage,
	Then zählt der NerdGolfTracker 3 Schlaege.