package ru.testapp.interfaces;

import ru.testapp.classes.Notebook;

import java.util.List;
import java.util.Map;

public interface IFilteredByOS {
    List<Notebook> filterByOS(List<Notebook> notebooks, String os);
}
