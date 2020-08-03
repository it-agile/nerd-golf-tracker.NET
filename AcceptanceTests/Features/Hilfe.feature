Feature: Hilfe

Scenario: Allgemeine Hilfe
	When ich die Hilfe aufrufe
	Then zeigt der NerdGolfTracker seine Benutzung an

Scenario Outline: Hilfe zu Kommandos
	When ich die Hilfe aufrufe
	Then erklärt der NerdGolfTracker das Kommando "<kommando>"

	Examples: 
	| kommando       |
	| Hilfe          |
	| Schlage Ball   |
	| Naechstes Loch |