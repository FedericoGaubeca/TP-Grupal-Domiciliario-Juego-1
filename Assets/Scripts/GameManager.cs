using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Producto[] productosIzquierda;
    public Producto[] productosDerecha;
    public Text productLPriceText;
    public Text productRPriceText;

    private Producto productoIzquierdaActual;
    private Producto productoDerechaActual;
    void Start()
    {
        DeactivateAllProducts();
        GenerateRandomProduct();
    }

    void DeactivateAllProducts()
    {
        foreach (var producto in productosIzquierda)
        {
            producto.gameObject.SetActive(false);
        }

        foreach (var producto in productosDerecha)
        {
            producto.gameObject.SetActive(false);
        }
    }

    void GenerateRandomProduct()
    {
        int indexIzquierda = Random.Range(0, productosIzquierda.Length);
        int indexDerecha = Random.Range(0, productosDerecha.Length);

        productoIzquierdaActual = productosIzquierda[indexIzquierda];
        productoDerechaActual = productosDerecha[indexDerecha];

        productoIzquierdaActual.gameObject.SetActive(true);
        productoDerechaActual.gameObject.SetActive(true);

        productLPriceText.text = productoIzquierdaActual.precio.ToString();
        productRPriceText.text = productoDerechaActual.precio.ToString();
    }

    public int ConseguirSumaTotal()
    {
        return productoIzquierdaActual.precio + productoDerechaActual.precio;
    }

}
