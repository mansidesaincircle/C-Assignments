   M S B A M L   `   `   `  ���� K  GWPFBasicMVVMDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WPFBasicMVVMDemoWPFBasicMVVMDemo  G(clr-namespace:WPFBasicMVVMDemo.ViewModelWPFBasicMVVMDemo.ViewModel  !    WPFBasicMVVMDemo.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0localclr-namespace:WPFBasicMVVMDemo     7vm(clr-namespace:WPFBasicMVVMDemo.ViewModel       � Title$  
MainWindow��$	��450��$	��800�� � 	Resources 0   *WPFBasicMVVMDemo.ViewModel.PersonViewModel   PersonViewModel��%   &	          .���  � DataContext ��  �� Source# [   � RowDefinitions �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $��* � � ColumnDefinitions �� $
��Auto ��� $��* �.+��� $��First Name:��$��0��$��0��$��Center=�$��5q��� $��0��$��1��$	��100��$��Center=�$��5q����� *Person.Fname+ �� Mode$ TwoWay=��� $��
Last Name:��$��1��$��0��$��Center=�$��5q��� $��1��$��1��$	��100��$��Center=�$��5q����� *Person.Lname+$ TwoWay=��� $��Submit��$��Center=�$��2��$��0��$��5q����� *SubmitCommand+�� $��3��$��1��$
��Auto��$��5q����� *	Persons+ �� View �� .P��� $��
First Name�� �� Width$
 Auto��	 �� DisplayMemberBinding	 �� 
 �� Path$
 Person.Fname� �� UpdateSourceTrigger$ PropertyChanged=��� $��	Last Name��$
 Auto��	 �� �� $��	Full Name��$
 Auto��	 �� 