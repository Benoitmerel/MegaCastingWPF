   M S B A M L   `   `   `  ����J  FMegaCastingsWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MegaCastingsWPFMegaCastingsWPF  5   	   "    MegaCastingsWPF.FenetreOffre   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:MegaCastingsWPF     5   	     � Title$  FenetreOffre��5   	   $	��700��6   $	��700��6+   .��5	      �  � RowDefinitions 5
   
   �� 5      $��30 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $��30 �6   �� 5      $	��300 �6   �� 5       $	��300 �6   .+�5$   
   �� $��Type de contrat��6   $��1��6+   $��1��6;   $��5q�6H   6U   �� 5%   
   -   5         ��Name$ CBX_TypesDecontrat��5%      $��2��6/   $��1��6?   $��5q�6L    �� SelectedItem 6X   �� *offre.TypesDeContrat+��6�   �� *ListeTypesDeContrat+��5&      �� 5'      .R�5(      �� ��6    �� *
NomContrat+5)      5+      �� 5.   
   $��Métier��6   $��1��6"   $��2��62   $��5q�6?   6L   �� 5/   
   -   5        $ 
CBX_Metier��5/      $��2��6'   $��2��67   $��5q�6D    6P   �� *offre.Metier+��6v   �� *ListeMetier+��50      �� 51      .R�52      �� ��6    �� *	NomMetier+53      55      �� 58   
   $��Nom du client��6   $��1��6(   $��3��68   $��5q�6E   6R   �� 59   
   -   5        $ 
CBX_Client��59      $��2��6'   $��3��67   $��5q�6D    6P   �� *offre.Client+��6v   �� *ListeClients+��5:      �� 5;      .R�5<      �� ��6    �� *Nom+5=      5?      �� 5B   
   $��Intitule��6   $��1��6#   $��4��63   $��5q�6@   6M   �� 5C   
   -   5         ��Name$ TXT_Intitule��5C      $��2��6(   $��4��68   $��5q�6F   ��6Q   �� *offre.Intitule+�� 5D   
   $��Référence��6   $��1��6%   $��5��65   $��5q�6C   6P   �� 5E   
   -   5        $ TXT_Reference��5E      $��2��6)   $��5��69   $��5q�6G   ��6R   �� *offre.Reference+�� 5G   
   $��Description du poste��6   $��1��6/   $��6��6?   $��5q�6M   6Z   �� 5H   
   -   5        $ TXT_DescritptionPoste��5H      $��2��61   $��6��6A   $��5q�6O   ��6Z   �� *offre.DescriptionPoste+�� 5I   
   $��Descritption du profil��6   $��1��62   $��7��6B   $��5q�6P   6]   �� 5J   
   -   5        $ TXT_DescritptionProfil��5J      $��2��62   $��7��6B   $��5q�6P   ��6[   �� *offre.DescriptionProfil+�� 5M   
   $��Localisation de l'offre��6   $��1��63   $��8��6C   $��5q�6P   6]   �� 5N   
   -   5        $ TXT_Localisation��5N      $��2��6,   $��8��6<   $��5q�6I   ��6T   �� *offre.Localisation+�� 5P   
   $��Nombre de poste��6   $��1��6*   $��9��6:   $��5q�6G   6T   �� 5Q   
   -	   5        $ TXT_NombreDePostes��5Q      $��2��6.   $��9��6>   $��5q�6K   ��6V   �� *offre.NombreDePostes+�� 5R   
   $��Date de publication��6   $��1��6/   $��10��6?   $��5q�6M   6Z   (  "System.Windows.Controls.DatePicker  5S   
   -
   5          Name$ TXT_DateDebutPublication��5S      $��2��67   $��10��6G   $��5q�6U      SelectedDate 6`   �� *offre.DateDebutPublication+�� 5U   
   $��Durée de diffusion��6   $��1��6.   $��11��6>   $��5q�6L   6Y   �� 5V   
   -   5        $ TXT_DureeDiffusion��5V      $��2��6.   $��11��6>   $��5q�6L   ��6W   �� *offre.DureeDeDiffusion+�� 5Y   
   -   5         ��Name$ BTN_Sauvegarder��5Y      $��1��6*   $��13��6:   $��5q�6H   .��6q   Sauvegarder6~   �� 5Z   
   -   5        $ BTN_Annuler��5Z      $��2��6&   $��13��66   $��5q�6E   .��6j   	Annuler6s   5[      5\      