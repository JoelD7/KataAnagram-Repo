# Algoritmo

- Se pide el nombre del archivo a inspeccionar.-> MainClass

- Se pasa el nombre del archivo a AnagramFinder. -> MainClass

- AnagramFinder pasa el nombre del archivo a FileReader. 

- Se lee cada palabra del archivo(338,869), almacenándolas en una estructura de datos a medida que se leen.  -> FileReader
Todas deben ser convertidas a lowercase. 

- AnagramFinder recibe el conjunto de palabras de FileReader.

- Se crea una lista de listas: anagramsGroup. -> AnagramFinder

- Se itera sobre el conjunto de palabras. -> AnagramFinder
    - Se toma una palabra base: currentWord. 
    - Se hace una posterior iteración sobre el conjunto completo, comparando a currentWord con cada palabra(menos ella) de la lista. 
    - Se agrupan las palabras que sean anagramas en una lista temporal: anagrams . 
    - Al final de la iteración, se agrega anagrams a anagramsGroup. 
    - Siguiente iteración. 

- Se itera sobre anagramsGroup para imprimir a cada grupo de anagramas encontrados. -> MainClass
