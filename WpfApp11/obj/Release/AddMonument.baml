   M S B A M L   `   `   `  ���� C  ?WpfApp11, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp11WpfApp11      WpfApp11.AddMonument   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:WpfApp11       � Title$  AddMonument��$	��450��$	��800�� � 
ResizeMode$ CanMinimize=�.��� 
������� � ColumnDefinitions �� $��* ��� $��* �.+��� $��Kraj:��$
��Left=�$��	40,40,0,0q�$	��Top=��� -    ��Name$ CountryTextBox��$
��Left=�$��23��$��	40,66,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��300��.������  �� 
TargetType" ��.���  �� Property �@��CharacterCasing �� Value$ Lower=� �� Triggers �� 	 �� Binding	 �� *Text.Length+
 �� RelativeSource
 �� *Self+ �� Value 0.a���  �@��CharacterCasing$ Upper=�.���� $��Miasto:��$
��Left=�$��	40,94,0,0q�$	��Top=��� -   $ CityTextBox��$
��Left=�$��23��$��
40,120,0,0q�$
 Wrap=�$	��Top=�$	��300��.������ " ��.���  �@��CharacterCasing$ Lower=� �� 	 �� *Text.Length+
 �� *Self+ 0.a���  �@��CharacterCasing$ Upper=�.���� $��Nazwa zabytku:��$
��Left=�$��
40,148,0,0q�$	��Top=��� -   $ MonumentTextBox��$
��Left=�$��23��$��
40,174,0,0q�$
 Wrap=�$	��Top=�$	��300��.������ " ��.���  �@��CharacterCasing$ Lower=� �� 	 �� *Text.Length+
 �� *Self+ 0.a���  �@��CharacterCasing$ Upper=�.���� $��Obraz:��$
��Left=�$��
40,202,0,0q�$	��Top=��� -   $ ImageTextBox��$
��Left=� �� 
IsReadOnly . $��23��$��
40,228,0,0q�$
 Wrap=�$	��Top=�$	��660��$��2���� $��Link do Google Maps:��$
��Left=�$��
40,256,0,0q�$	��Top=��� -   $ GoogleMapsLinkTextBox����. $
��Auto=�$
��Auto=�$
��Left=�$��23��$��
40,282,0,0q�$
 Wrap=�$	��Top=�$	��660��$��2���� $��Opis:��$��1��$
��Left=�$��	40,40,0,0q�$	��Top=��� -   $ DescriptionTextBox��$��1��$
��Left=�$	��131��$��	40,66,0,0q�$
 Wrap=�$	��Top=�$	��300���� -   $��Dodaj zabytek��$
��Left=�$��340,333,0,0q�$	��Top=�$��96��$��2��$��38���� -    ��Name$ Browse��$��Otwórz��$
��Left=�$��309,228,0,0q�$	��Top=�$��55��$��23�� J� RenderTransformOrigin$ 6.451,0.391&�$��1��