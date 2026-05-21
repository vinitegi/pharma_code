CREATE TABLE IF NOT EXISTS categoria (
    id SERIAL PRIMARY KEY,
    nome VARCHAR(100) NOT NULL
);


CREATE TABLE remedio (
    id SERIAL PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    descricao VARCHAR(255),
    preco NUMERIC(10,2),
    estoque INT,
    categoria_id INT NOT NULL,
    CONSTRAINT fk_remedio_categoria
        FOREIGN KEY (categoria_id)
        REFERENCES categoria(id)
);

select * from remedio;

select * from categoria;

SELECT column_name
FROM information_schema.columns
WHERE table_name = 'remedio';

ALTER TABLE remedio
ADD COLUMN quantidade INT NOT NULL DEFAULT 0;

ALTER TABLE remedio
DROP COLUMN estoque;

ALTER TABLE remedio
ADD COLUMN validade DATE;
