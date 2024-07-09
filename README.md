# CorrectionTP2

En tant que client de l'API à la clôture d'un scrutin
	Je souhaite calculer le résultat du scrutin
	Pour obtenir le vainqueur du vote

	- Pour obtenir un vainqueur, le scrutin doit être clôturé
	- Si un candidat obtient > 50% des voix, il est déclaré vainqueur
	- On veut pouvoir afficher le nombre de votes pour chaque candidat et le pourcentage correspondant à la clôture du scrutin.
	- Si aucun candidat n'a plus de 50%, alors on garde les 2 candidats correspondants aux meilleurs pourcentages et il y aura un deuxième tour de scrutin
	- Il ne peut y avoir que deux tours de scrutins maximums
	- Sur le dernier tour de scrutin, le vainqueur est le candidat ayant le pourcentage de vote le plus élevé
	- Si on a une égalité sur un dernier tour, on ne peut pas déterminer de vainqueur

	Evolution
	- Gestion des égalités sur le 2ème et 3ème candidat sur un premier tour
		- Règle métier choisie: en cas d'égalité au premier tour, le candidat le plus âgé est qualifié au deuxième tour
	- Gestion du vote blanc
		- Règle métier choisie: les votes blancs ou nuls ne sont pas comptabilisés dans les suffrages exprimés
								, mais ils sont décomptés à part et on veut pouvoir en connaître le nombre pour chaque tour 
