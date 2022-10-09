select
        p.name,
        c.name
    from products p
    left join product_category pc on p.id = pc.product_id
    left join category c on pc.category_id = c.id