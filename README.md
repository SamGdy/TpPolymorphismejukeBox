# TpPolymorphismejukeBox

Présentation du projet : l'objectif est d'utiliser le polymorphisme de l'héritage. Il permet de posséder plusieurs méthodes d'un même nom dans des classes issues d'une hiérarchie. Avec les mots clef "Virtual" et "Override".

Les outils mis en oeuvre :
* visual studio
* Heritage, polymorphisme

On travail sur des classes issues de "Media"

![Capture.png](https://github.com/SamGdy/TpPolymorphismejukeBox/blob/master/Images/DiagrammeClasseJukeBox.JPG)

la méthode "Afficher" de la classe Media est en virtual :

![Capture.png](https://github.com/SamGdy/TpPolymorphismejukeBox/blob/master/Images/Methodemedia.PNG)

Les classes Video et Cd sont des filles de Media et possédent aussi leur méthodes Afficher. On utilise alors le mot : "override".

![Capture.png](https://github.com/SamGdy/TpPolymorphismejukeBox/blob/master/Images/MethodeVideoMedia.PNG)

![Capture.png](https://github.com/SamGdy/TpPolymorphismejukeBox/blob/master/Images/MethodeCd.PNG)

Grace à ces Mots clés on utilise la méthode Afficher pour un Objet Média et le polymorphisme appelle la méthode afficher de l'objet en question. 
