/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package zadatak2zavrsniispit;

import com.microsoft.sqlserver.jdbc.SQLServerDataSource;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.sql.Types;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import javax.sql.DataSource;

/**
 *
 * @author office
 */
public class Zadatak2ZavrsniIspit {
    
    private static Scanner sc = new Scanner(System.in);
    private static List<Krava> listaKrava = new ArrayList<>();
    private static List<ProizvodnjaMlijeka> listaUzimanja = new ArrayList<>();
    private static double KOLICINA_MLIJEKA = 3.0;
    
    public static void main(String[] args) {
        int godina = 0;
        boolean upis = true;
        System.out.println("Upisite godinu za koju zelite prosijek danog mlijeka:");
        
        do {            
            try {
                godina = sc.nextInt();
                upis = false;
            } catch (Exception e) {
                System.out.println("Unijeli ste nesto sta nije godina, molimo unesite ponovo..");
                upis = true;
                sc.next();
            }
        } while (upis);
        
        FetchDataAndCheckResults(godina);
    }

    private static void FetchDataAndCheckResults(int godina) {
        DataSource ds = CreateDataSource();
        ShowAverageYearMilkQuantity(ds, godina);
    }

    private static DataSource CreateDataSource() {
        SQLServerDataSource dataSource = new SQLServerDataSource();
        dataSource.setServerName("localhost");
        dataSource.setDatabaseName("Kravadoo");
        dataSource.setUser("sa");
        dataSource.setPassword("SQL");
        return dataSource;
    }

    private static void ShowAverageYearMilkQuantity(DataSource ds, int godina) {
        try (Connection con = ds.getConnection()){
            boolean anyCowsOverAverage = false;
            CallableStatement csAverage = con.prepareCall("{CALL AverageYearMilk(?)}");
            csAverage.setInt("godina", godina);
            
            CallableStatement csAverageCow = con.prepareCall("{CALL AverageYearMilkForCow(?)}");
            csAverageCow.setInt("godina", godina);
            ResultSet averageSet = csAverage.executeQuery();
            ResultSet averageCowSet = csAverageCow.executeQuery();
            
            System.out.println("");
            while (averageSet.next()) {
                double avg = averageSet.getDouble("Average");
                if (avg == 0.0)
                    System.out.println("Nemamo pohranjenih podataka za unesenu godinu..");
                else
                    System.out.println(String.format("Dnevna kolicina mlijeka u %d godini je %.2f.", godina, avg));
            }
            
            System.out.println("");
            System.out.println(String.format("Krave koje su dale vise od %.2f mlijeka u %d godini.", KOLICINA_MLIJEKA, godina));
            while (averageCowSet.next()) {
                double avg = averageCowSet.getDouble("Average");
                if (avg > KOLICINA_MLIJEKA) {
                    anyCowsOverAverage = true;
                    String ime = averageCowSet.getString("Ime");
                    System.out.println(String.format("Ime: %s, Kolicina mlijeka: %.2f", ime, avg));
                }
            }
            
            if (!anyCowsOverAverage)
                System.out.println(String.format("Nije pronadjena nijedna krava koja je dala vise od %.2f mlijeka.", KOLICINA_MLIJEKA));
        } catch (Exception e) {
            System.out.println("Oops");
        }
        
        listaKrava.stream().forEach(k -> System.out.println(k));
    }
    
}
