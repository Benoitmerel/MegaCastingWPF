   M S B A M L   `   `   `  ����J  FMegaCastingsWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MegaCastingsWPFMegaCastingsWPF  5           MegaCastingsWPF.OffresView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:MegaCastingsWPF     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $��* �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��* �6   .+�5   
   �� $��10q�6   $��Offres��6   $��0��60   .��5      � .+�5      �� -   5         ��Name$ 
LST_Offres��5      ��6.   �� *ListeOffres+��5      �� 5      .R�5      �� ��6(   �� *
Intitule+5      5      5      5      �� 5   
   -   5         ��Name$ BTN_Ajouter��5      $��10q�6   $��1��63   $��0��6@   $��5q�6P   .��6v   	Ajouter6   � 5    
   $��10q�6   $��1��6     5!      �� 5"      $��30 �6    �� 5#      $
��auto �6    �� 5$      $
��auto �6    �� 5%      $
��auto �6    �� 5&      $
��auto �6    �� 5'      $
��auto �6    �� 5(      $
��auto �6    �� 5)      $
��auto �6    �� 5*      $
��auto �6    �� 5+      $
��auto �6    �� 5,      $
��auto �6    �� 5-      $
��auto �6    �� 5.      $��* �6    �� 5/      $
��auto �6     53      �� 54      $��30 �6#   �� 55      $	��150 �6#   �� 56      $	��150 �6#   �� 57      $	��150 �6#   .+�5:      �� $��Type de contrat��6   $��1��6/   $��1��6?   $��5q�6L   6Y   �� 5;      -   5         ��Name$ CBX_TypesDecontrat��5;      $��2��63   $��1��6C   $��5q�6P    �� SelectedItem 6[   ��  �� ElementName$ 
LST_Offres�� �� Path$! SelectedItem.TypesDeContrat���6�   �� *ListeTypesDeContrat+��5<      �� 5=      .R�5>      �� ��6$   �� *
NomContrat+5?      5A      �� 5D      $��Métier��6   $��1��6&   $��2��66   $��5q�6C   6P   �� 5E      -   5        $ 
CBX_Metier��5E      $��2��6+   $��2��6;   $��5q�6H    6S   �� $ 
LST_Offres��$ SelectedItem.Metier���6�   �� *ListeMetier+��5F      �� 5G      .R�5H      �� ��6$   �� *	NomMetier+5I      5K      �� 5N      $��Nom du client��6   $��1��6,   $��3��6<   $��5q�6I   6V   �� 5O      -   5        $ 
CBX_Client��5O      $��2��6+   $��3��6;   $��5q�6H    6S   �� $ 
LST_Offres��$ SelectedItem.Client� �� UpdateSourceTrigger$ PropertyChanged=���6�   �� *ListeClients+��5P      �� 5Q      .R�5R      �� ��6$   �� *Nom+5S      5U      �� 5X      $��Intitule��6   $��1��6'   $��4��67   $��5q�6D   6Q   �� 5Y      -   5        	 ��Name$	 TXT_Intitule��5Y      $��2��6,   $��4��6<   $��5q�6J   ��6U   �� $ 
LST_Offres��$ SelectedItem.Intitule��� 5Z      $��Référence��6   $��1��6)   $��5��69   $��5q�6G   6T   �� 5[      -   5        $	 TXT_Reference��5[      $��2��6-   $��5��6=   $��5q�6K   ��6V   �� $ 
LST_Offres��$ SelectedItem.Reference��� 5]      $��Description du poste��6   $��1��63   $��6��6C   $��5q�6Q   6^   �� 5^      -   5        $	 TXT_DescritptionPoste��5^      $��2��65   $��6��6E   $��5q�6S   ��6^   �� $ 
LST_Offres��$# SelectedItem.DescriptionPoste��� 5_      $��Descritption du profil��6   $��1��66   $��7��6F   $��5q�6T   6a   �� 5`      -	   5        $	 TXT_DescritptionProfil��5`      $��2��66   $��7��6F   $��5q�6T   ��6_   �� $ 
LST_Offres��$$ SelectedItem.DescriptionProfil��� 5c      $��Localisation de l'offre��6   $��1��67   $��8��6G   $��5q�6T   6a   �� 5d      -
   5        $	 TXT_Localisation��5d      $��2��60   $��8��6@   $��5q�6M   ��6X   �� $ 
LST_Offres��$ SelectedItem.Localisation��� 5f      $��Nombre de poste��6   $��1��6.   $��9��6>   $��5q�6K   6X   �� 5g      -   5        $	 TXT_NombreDePostes��5g      $��2��62   $��9��6B   $��5q�6O   ��6Z   �� $ 
LST_Offres��$! SelectedItem.NombreDePostes��� 5h      $��Date de publication��6   $��1��63   $��10��6C   $��5q�6Q   6^   (  "System.Windows.Controls.DatePicker  5i      -   5        
  Name$
 TXT_DateDebutPublication��5i      $��2��6;   $��10��6K   $��5q�6Y      SelectedDate 6d   �� $ 
LST_Offres��$' !SelectedItem.DateDebutPublication��� 5k      $��Durée de diffusion��6   $��1��62   $��11��6B   $��5q�6P   6]   �� 5l      -   5        $	 TXT_DureeDiffusion��5l      $��2��62   $��11��6B   $��5q�6P   ��6[   �� $ 
LST_Offres��$# SelectedItem.DureeDeDiffusion��� 5n      -   5        $ BTN_Modifier��5n   "   $��10q�6   $��13��68   $��2��6G   $��5q�6W   .��6~   
Modifier6�   �� 5o      -   5        $ BTN_Supprimer��5o   "   $��10q�6   $��13��69   $��3��6H   $��5q�6X   .��6�   	Supprimer6�   5p      5q      5r      