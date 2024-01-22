package ru.testapp.interfaces;

import ru.testapp.classes.Notebook;

import java.util.List;


public interface IFilteredByRAM {
      List<Notebook> filterByRAM(List<Notebook> notebooks, int minRAM, int maxRAM);
}
