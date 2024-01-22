package ru.testapp.classes;

import ru.testapp.interfaces.IFilteredByOS;
import ru.testapp.interfaces.IFilteredByRAM;
import java.util.List;
import java.util.stream.Collectors;

public class Filters implements IFilteredByRAM, IFilteredByOS {

    @Override
    public List<Notebook> filterByRAM(List<Notebook> notebooks, int minRAM, int maxRAM) {
        return notebooks.stream()
                .filter(notebook -> notebook.getRam() >= minRAM && notebook.getRam() <= maxRAM)
                .collect(Collectors.toList());
    }

    public List<Notebook> filterByStorageCapacity(List<Notebook> notebooks, int minStorageCapacity, int maxStorageCapacity) {
        return notebooks.stream()
                .filter(notebook -> notebook.getStorageCapacity() >= minStorageCapacity && notebook.getStorageCapacity() <= maxStorageCapacity)
                .collect(Collectors.toList());
    }

    @Override
    public  List<Notebook> filterByOS(List<Notebook> notebooks, String os) {
        return notebooks.stream()
                .filter(notebook -> notebook.getOs().equalsIgnoreCase(os))
                .collect(Collectors.toList());
    }

        public List<Notebook> filterByColor(List<Notebook> notebooks, String color) {
        return notebooks.stream()
                .filter(notebook -> notebook.getColor().equalsIgnoreCase(color))
                .collect(Collectors.toList());
    }

    public List<Notebook> filterByLabel(List<Notebook> notebooks, String label) {
        return notebooks.stream()
                .filter(notebook -> notebook.getLabel().equalsIgnoreCase(label))
                .collect(Collectors.toList());
    }
}
