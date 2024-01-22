package ru.testapp.classes;

import ru.testapp.enums.NotebookColors;
import ru.testapp.enums.NotebookLabels;
import ru.testapp.enums.NotebookOSNames;

import java.util.*;

public class App {

    Filters filters = new Filters();
    List<Notebook> notebooks = notebooksList();
    public void startApp() throws InputMismatchException {
        try {
            StringBuilder sb = new StringBuilder();
            System.out.println(sb.append(
                    "1. Фильтрация по одному параметру" +"\n"));
//                            + "2. Фильтрация по нескольким параметрам"+"\n"));
            sb.delete(0,sb.length());//clearing sb
            Scanner scanner = new Scanner(System.in);
            System.out.println(sb.append("Выберите необходимый вид фильтрации ( 0 = выыход) : \n"));

            int request = scanner.nextInt();
            if (request > 2) {
                System.out.println(sb.append("Некорректно выбран пункт, пожалуйста введите корректное значение пункта повторно : "));
                startApp();
            } else if (request == 2) {

            } else if (request == 1) {
                oneFilter();
            } else System.out.println("Вы завершили работу приложения!"); return;
        }catch (InputMismatchException e){
            System.out.println("Введён некоректный тип данных, приложение завершает работу.");
            System.out.println(e.getMessage());
        }
        System.out.println("\r");

    }


    public static List<Notebook> notebooksList (){
        return Arrays.asList(
                new Notebook(4,128, NotebookOSNames.WINDOWS.getName(), NotebookColors.NOTEBOOK_COLORS_BLACK.getColor(), NotebookLabels.NOTEBOOK_LABELS_ASUS.getName()),
                new Notebook(8,256, NotebookOSNames.WINDOWS.getName(), NotebookColors.NOTEBOOK_COLORS_BLACK.getColor(), NotebookLabels.NOTEBOOK_LABELS_ASUS.getName()),
                new Notebook(4,256, NotebookOSNames.WINDOWS.getName(), NotebookColors.NOTEBOOK_COLORS_BLACK.getColor(), NotebookLabels.NOTEBOOK_LABELS_ASUS.getName()),
                new Notebook(16,256, NotebookOSNames.WINDOWS.getName(), NotebookColors.NOTEBOOK_COLORS_BLACK.getColor(), NotebookLabels.NOTEBOOK_LABELS_ACER.getName()),
                new Notebook(4,512, NotebookOSNames.WINDOWS.getName(), NotebookColors.NOTEBOOK_COLORS_BLUE.getColor(), NotebookLabels.NOTEBOOK_LABELS_ASUS.getName()),
                new Notebook(32,1024, NotebookOSNames.WINDOWS.getName(), NotebookColors.NOTEBOOK_COLORS_RED.getColor(), NotebookLabels.NOTEBOOK_LABELS_LENOVO.getName()),
                new Notebook(8,256, NotebookOSNames.WINDOWS.getName(), NotebookColors.NOTEBOOK_COLORS_BLUE.getColor(), NotebookLabels.NOTEBOOK_LABELS_ACER.getName()),
                new Notebook(16,256, NotebookOSNames.WINDOWS.getName(), NotebookColors.NOTEBOOK_COLORS_SILVER.getColor(), NotebookLabels.NOTEBOOK_LABELS_ASUS.getName()),
                new Notebook(32,256, NotebookOSNames.UBUNTU_20_04.getName(), NotebookColors.NOTEBOOK_COLORS_SILVER.getColor(), NotebookLabels.NOTEBOOK_LABELS_LENOVO.getName()),
                new Notebook(4,256, NotebookOSNames.CENTOS_7.getName(), NotebookColors.NOTEBOOK_COLORS_RED.getColor(), NotebookLabels.NOTEBOOK_LABELS_LENOVO.getName()),
                new Notebook(8,256, NotebookOSNames.WINDOWS.getName(), NotebookColors.NOTEBOOK_COLORS_BLUE.getColor(), NotebookLabels.NOTEBOOK_LABELS_ASUS.getName()),
                new Notebook(16,256, NotebookOSNames.UBUNTU_20_04.getName(), NotebookColors.NOTEBOOK_COLORS_SILVER.getColor(), NotebookLabels.NOTEBOOK_LABELS_ASUS.getName()),
                new Notebook(16,256, NotebookOSNames.WINDOWS.getName(), NotebookColors.NOTEBOOK_COLORS_BLACK.getColor(), NotebookLabels.NOTEBOOK_LABELS_ASUS.getName()),
                new Notebook(4,256, NotebookOSNames.WINDOWS.getName(), NotebookColors.NOTEBOOK_COLORS_BLACK.getColor(), NotebookLabels.NOTEBOOK_LABELS_ASUS.getName()),
                new Notebook(16,256, NotebookOSNames.CENTOS_7.getName(), NotebookColors.NOTEBOOK_COLORS_BLACK.getColor(), NotebookLabels.NOTEBOOK_LABELS_ASUS.getName()),
                new Notebook(64,256, NotebookOSNames.WINDOWS.getName(), NotebookColors.NOTEBOOK_COLORS_BLACK.getColor(), NotebookLabels.NOTEBOOK_LABELS_ASUS.getName()),
                new Notebook(16,256, NotebookOSNames.UBUNTU_20_04.getName(), NotebookColors.NOTEBOOK_COLORS_BLACK.getColor(), NotebookLabels.NOTEBOOK_LABELS_ASUS.getName())


        );
    }

    public void oneFilter(){
        StringBuilder sb = new StringBuilder();
        sb.delete(0,sb.length());//clearing sb
            System.out.println(sb.append(
                    "1. Фильтрация по оперативной памяти (RAM).\n"+
                    "2. Фильтрация по объему диска (drive).\n"+
                    "3. Фильтрация по производителю. \n"+
                    "4. Фильтрация по операционной системе.\n"+
                    "5. Фильтрация по цвету ноутбука\n"));

            System.out.println(sb.append("Выберите необходимый параметр фильтрации ( 0 = выыход) : \n"));
            int request = new Scanner(System.in).nextInt();
            if (request == 1) {
                System.out.println(sb.append("Введите минимальное значение для фильтра : \n"));
                int minCount = new Scanner(System.in).nextInt();
                System.out.println(sb.append("Введите максимальное значение для фильтра : \n"));
                int maxCount = new Scanner(System.in).nextInt();
                System.out.println(sb.append("Результаты работы программы : \n"));
                filters.filterByRAM(notebooks,minCount,maxCount).forEach(System.out::println);
            } else if (request==2) {
                System.out.println(sb.append("Введите минимальное значение для фильтра (Мин 128) : \n"));
                int minCount = new Scanner(System.in).nextInt();
                System.out.println(sb.append("Введите максимальное значение для фильтра (Максисмум 1024 \n"));
                int maxCount = new Scanner(System.in).nextInt();
                System.out.println(sb.append("Результаты работы программы : \n"));
                filters.filterByStorageCapacity(notebooks,minCount,maxCount).forEach(System.out::println);
            } else if (request==3) {labelFilter();}
            else if (request==4) {
                osFilter();
            } else if (request==5) {
                colorFilter();
            }else {
                System.out.println(sb.append("Некорректно выбран пункт, пожалуйста введите корректное значение пункта повторно : "));
                startApp();
            }

    }


    public  void  labelFilter(){
        StringBuilder sb = new StringBuilder();
        System.out.println(sb.append("\nВыберите производителя из списка : \n" + NotebookLabels.getLabelNames()));
        int request = new Scanner(System.in).nextInt();
        if (request==1){
            System.out.println(sb.append("Результаты работы программы : \n"));
            filters.filterByLabel(notebooks,NotebookLabels.NOTEBOOK_LABELS_ASUS.getName()).forEach(System.out::println);
        } else if (request==2) {
            System.out.println(sb.append("Результаты работы программы : \n"));
            filters.filterByLabel(notebooks,NotebookLabels.NOTEBOOK_LABELS_LENOVO.getName()).forEach(System.out::println);
        } else if (request==3) {
            System.out.println(sb.append("Результаты работы программы : \n"));
            filters.filterByLabel(notebooks,NotebookLabels.NOTEBOOK_LABELS_ACER.getName()).forEach(System.out::println);
        } else if (request==0) {
            System.out.println(sb.append("Вы завершили работу программы"));
        } else {
            System.out.println(sb.append("Некорректно выбран пункт, пожалуйста введите корректное значение пункта повторно : "));
            startApp();
        }
    }

    public  void  osFilter(){
        StringBuilder sb = new StringBuilder();
        System.out.println(sb.append("\nВыберите операционную систему из списка : \n" + NotebookOSNames.getOSNames()));
        int request = new Scanner(System.in).nextInt();
        if (request==1){
            System.out.println(sb.append("Результаты работы программы : \n"));
            filters.filterByOS(notebooks,NotebookOSNames.UBUNTU_20_04.getName()).forEach(System.out::println);
        } else if (request==2) {
            System.out.println(sb.append("Результаты работы программы : \n"));
            filters.filterByLabel(notebooks,NotebookOSNames.CENTOS_7.getName()).forEach(System.out::println);
        } else if (request==3) {
            System.out.println(sb.append("Результаты работы программы : \n"));
            filters.filterByLabel(notebooks,NotebookOSNames.WINDOWS.getName()).forEach(System.out::println);
        } else if (request==0) {
            System.out.println(sb.append("Вы завершили работу программы"));
        } else {
            System.out.println(sb.append("Некорректно выбран пункт, пожалуйста введите корректное значение пункта повторно : "));
            startApp();
        }
    }

    public  void  colorFilter(){
        StringBuilder sb = new StringBuilder();
        System.out.println(sb.append("\nВыберите цвет ноутбука из из списка : \n" + NotebookColors.getColorNotebook()));
        int request = new Scanner(System.in).nextInt();
        if (request==1){
            System.out.println(sb.append("Результаты работы программы : \n"));
            filters.filterByColor(notebooks,NotebookColors.NOTEBOOK_COLORS_RED.getColor()).forEach(System.out::println);
        } else if (request==2) {
            System.out.println(sb.append("Результаты работы программы : \n"));
            filters.filterByColor(notebooks,NotebookColors.NOTEBOOK_COLORS_BLUE.getColor()).forEach(System.out::println);
        } else if (request==3) {
            System.out.println(sb.append("Результаты работы программы : \n"));
            filters.filterByColor(notebooks,NotebookColors.NOTEBOOK_COLORS_SILVER.getColor()).forEach(System.out::println);
        }else if (request==4) {
            System.out.println(sb.append("Результаты работы программы : \n"));
            filters.filterByColor(notebooks, NotebookColors.NOTEBOOK_COLORS_BLACK.getColor()).forEach(System.out::println);
        }else if (request==0) {
            System.out.println(sb.append("Вы завершили работу программы"));
        } else {
            System.out.println(sb.append("Некорректно выбран пункт, пожалуйста введите корректное значение пункта повторно : "));
            startApp();
        }
    }
}
